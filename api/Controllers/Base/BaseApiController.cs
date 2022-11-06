using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using JSLibrary;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using ngJSApp.Database;

namespace ngJSApp.Controllers
{
    [ApiController]
    public partial class BaseApiController : ControllerBase
    {
        protected AppDbContext ctx = null;
        private readonly IWebHostEnvironment env;
        protected IAppCrypterService appCrypter = null;
        protected IConfiguration _Configuration { get; }

        public BaseApiController(AppDbContext _ctx, IWebHostEnvironment _env, IAppCrypterService _appCrypter, IConfiguration configuration)
        {
            this.ctx = _ctx;
            this.env = _env;
            this.appCrypter = _appCrypter;
            this._Configuration = configuration;

        }

        protected List<dynamic> Query(string SQL)
        {
            var p = this.GetPagingResult(new PagingParams()
            {
                SQL = SQL
            });
            return p.Data;
        }

        protected PagingResult GetPagingResult(PagingParams P)
        {
            PagingResult result = null;
            string SQL = P.SQL; //["SQL"];
            var primaryKey = P.PrimaryKey;//["primaryKey"];
            JObject filterParams = null;//["params"];
            int? skip = P.Skip;//["skip"];
            int? take = P.Take;//["take"];
            JObject filterObject = P.FilterOption != null ? JObject.Parse(P.FilterOption) : null;//["filter"];
            var filterFormValue = P.filterFormValue;

            string searchValue = P.SearchValue;//["searchValue"];
            if (String.IsNullOrWhiteSpace(searchValue) == true) searchValue = null;
            string sort = P.SortingOption;//["sort"];
            JArray customFilter = null;//["customFilter"];
            string Value = P.Value;
            string[] groupsColumns = String.IsNullOrWhiteSpace(P.GroupOptions) != true ? P.GroupOptions.Split(",") : new string[] { };
            //SQL = Utils.Decrypt(SQL);

            if (filterObject != null)
            {
                if (filterObject.Properties().Count() == 0)
                {
                    filterObject = null;
                }
            }
            //string jsonResult = null;
            if (filterParams != null)
            {
                var filterParamsProperties = ((JObject)filterParams).Properties().ToArray<JProperty>();
                if (filterParamsProperties.Length > 0)
                {
                    var ObjectParameters = Regex.Matches(SQL, "(\\@\\w+)").Cast<Match>().Select(s => s.Groups[1].Value).ToList<string>();
                    var GlobalParameters = Regex.Matches(SQL, "(\\#\\w+)").Cast<Match>().Select(s => s.Groups[1].Value).ToList<string>();
                    foreach (JProperty p in filterParamsProperties)
                    {
                        if (filterParams[p.Name].GetType() == typeof(JArray))
                        {
                            var Values = ((JArray)filterParams[p.Name]).Values().ToList();
                            if (Values.Count > 0)
                            {
                                JTokenType type = ((JArray)filterParams[p.Name]).Values().ToList()[0].Type;
                                switch (type)
                                {
                                    case JTokenType.Float:
                                    case JTokenType.Integer:
                                        SQL = SQL.Replace("@" + p.Name, String.Join(",", ((JArray)filterParams[p.Name]).Values().ToList()));
                                        break;
                                    case JTokenType.String:
                                    case JTokenType.Date:
                                        SQL = SQL.Replace("@" + p.Name, String.Join(",", ((JArray)filterParams[p.Name]).Values().Select(s => "'" + s.ToObject<string>().Replace("'", "''") + "'").ToList()));
                                        break;
                                }
                            }
                        }
                        else
                        {
                            var value = ((JValue)filterParams[p.Name]).Value;
                            if (value != null)
                            {
                                if (value.GetType() == typeof(string))
                                {
                                    SQL = SQL.Replace(p.Name, "'" + (value as string).Replace("'", "''") + "'");
                                }
                                else
                                {
                                    SQL = SQL.Replace(p.Name, value.ToString());
                                }
                            }
                            else
                            {
                                SQL = SQL.Replace(p.Name, "NULL");
                            }
                        }
                    }
                }
            }
            //
            //  FILTER
            //
            string OrderBy = null;
            int OrderByIndex = SQL.IndexOf("ORDER BY");
            if (OrderByIndex > -1)
            {
                OrderBy = SQL.Substring(OrderByIndex, SQL.Length - OrderByIndex);
                SQL = SQL.Substring(0, OrderByIndex - 1);
            }

            DataTable BaseTableSchema = null;
            if (filterObject != null || searchValue != null || customFilter != null || groupsColumns != null || String.IsNullOrEmpty(filterFormValue) != true)
            {
                if (SQL.ToUpper().Contains("WHERE") == false)
                {
                    SQL = SQL + " WHERE ( 1 = 1 )";
                };
                BaseTableSchema = JSCommon.SQL.GetSQLSchema(SQL, true);
            }

            if (Value != null)
            {
                if (SQL.ToUpper().Contains("WHERE") == false)
                {
                    SQL = SQL + " WHERE ( 1 = 1 )";
                };
            }

            if (filterObject != null && BaseTableSchema != null)
            {
                //var property = filterObject.Properties();
                List<String> list = new List<string>();
                foreach (DataRow row in BaseTableSchema.Rows)
                {
                    Type dataType = (Type)row["DataType"];
                    string ColumnName = row["ColumnName"].ToString();
                    if (filterObject.Property(ColumnName) == null) continue;
                    var value = filterObject.GetValue(ColumnName);
                    if (value == null) continue;
                    if (value.Type == JTokenType.String)
                    {
                        var strValue = value.ToObject<string>();
                        if (String.IsNullOrWhiteSpace(strValue)) continue;
                        value = strValue.Trim();
                    }
                    if (new string[] { "VIEW" }.ToList().Contains(ColumnName.ToUpper()))
                    {
                        ColumnName = "[" + ColumnName + "]";
                    }
                    if (ColumnName.StartsWith("$")) ColumnName = "[" + ColumnName + "]";
                    if (dataType == typeof(string) || dataType == typeof(String))
                    {
                        list.Add(" (" + ColumnName + " LIKE '%" + value + "%')");
                    }
                    else
                    {
                        list.Add("(CAST(" + ColumnName + " AS VARCHAR(100)) LIKE '%" + value + "%')");
                    }
                }
                if (list.Count > 0)
                {
                    SQL += " AND (" + String.Join(" AND ", list) + ")";
                }
            }

            if (String.IsNullOrEmpty(filterFormValue) != true)
            {
                var filters = JArray.Parse(filterFormValue);
                var whereClauseList = new List<string>();
                foreach (var f in filters)
                {
                    var dataField = f["dataField"].Value<string>();
                    var filterCriteriaType = (FilterCriteriaType)Int32.Parse(f["filterCriteriaType"].Value<string>());
                    var PropertyType = (PropertyTypeEnum)f["propertyType"].Value<Int32>();
                    var _value = f["value"];
                    var Values = new List<string>();

                    if (_value.Type == JTokenType.Array)
                    {
                        Values = _value.ToArray<object>().Select(s => s.ToString()).ToList();
                    }
                    else
                    {
                        Values.Add(_value.Value<object>().ToString());
                    }
                    if (Values.Count == 0) continue;
                    switch (PropertyType)
                    {
                        case PropertyTypeEnum.Uniqueidentifier:
                        case PropertyTypeEnum.String:
                            //Values = Values.Select(d => "'" + d.Replace("'", "''") + "'").ToList();
                            break;
                        //case PropertyTypeEnum.Int:
                        //    break;
                        //case PropertyTypeEnum.Decimal:
                        //    break;
                        //case PropertyTypeEnum.Bit:
                        //    break;
                        case PropertyTypeEnum.Date:
                        case PropertyTypeEnum.DateTime:
                            if (Values.Count == 1)
                            {
                                Values[0] = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                            }
                            break;
                    }
                    string whereClause = null;
                    switch (filterCriteriaType)
                    {
                        case FilterCriteriaType.Equal:
                            if (PropertyType == PropertyTypeEnum.String)
                            {
                                whereClause = $"{dataField} = '{Values[0].Replace("'", "''")}'";
                            }
                            else if (PropertyType == PropertyTypeEnum.Date)
                            {

                                whereClause = $"CONVERT(DATE,{dataField},23) = '{Values[0].Replace("'", "''")}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} = {Values[0].Replace("'", "''")}";
                            }
                            break;
                        case FilterCriteriaType.NotEqual:
                            if (PropertyType == PropertyTypeEnum.String)
                            {
                                whereClause = $"{dataField} <> '{Values[0].Replace("'", "''")}'";
                            }
                            else if (PropertyType == PropertyTypeEnum.Date)
                            {

                                whereClause = $"CONVERT(DATE,{dataField},23) <> '{Values[0].Replace("'", "''")}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} <> {Values[0].Replace("'", "''")}";
                            }
                            break;
                        case FilterCriteriaType.Contains:
                            whereClause = $"{dataField} IN ({string.Join(',', Values)})";
                            break;
                        case FilterCriteriaType.NotContains:
                            whereClause = $"{dataField} NOT IN ({string.Join(',', Values)})";
                            break;
                        case FilterCriteriaType.Like:
                            whereClause = $"{dataField} LIKE '%{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.NotLike:
                            whereClause = $"{dataField} NOT LIKE '%{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.StartWith:
                            whereClause = $"{dataField} NOT LIKE '{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.EndWith:
                            whereClause = $"{dataField} NOT LIKE '%{Values[0].Replace("'", "''")}'";
                            break;
                        case FilterCriteriaType.GreaterThan:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                //var DateValue = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                                whereClause = $"CONVERT(DATE,{dataField},23) > '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} > {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.LessThan:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                //var DateValue = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                                whereClause = $"CONVERT(DATE,{dataField},23) < '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} < {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.GreaterThanEqual:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                Values[0] = DateTime.Parse(Values[0]).AddDays(-1).ToString("yyyy-MM-dd");
                                whereClause = $"CONVERT(DATE,{dataField},23) > '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} >= {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.LessThanEqual:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                Values[0] = DateTime.Parse(Values[0]).AddDays(1).ToString("yyyy-MM-dd");
                                whereClause = $"CONVERT(DATE,{dataField},23) < '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} <= {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.Between:
                            var StartDate = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                            var EndDate = DateTime.Parse(Values[1]).AddDays(1).ToString("yyyy-MM-dd");
                            whereClause = $"{dataField} BETWEEN '{StartDate}' AND '{EndDate}'";
                            break;
                    }
                    whereClauseList.Add($"({whereClause})");
                }
                if (whereClauseList.Count > 0)
                {
                    SQL += " AND " + String.Join(" AND ", whereClauseList);
                }
            }
            if (customFilter != null)
            {
                if (customFilter.Count > 0)
                {
                    SQL += " AND (" + string.Join(" AND ", customFilter.Select(s => "(" + s.ToObject<string>() + ")")) + ")";
                }
            }

            if (searchValue != null && BaseTableSchema != null)
            {

                var list = new List<string>();
                foreach (DataRow row in BaseTableSchema.Rows)
                {
                    Type dataType = (Type)row["DataType"];
                    string ColumnName = row["ColumnName"].ToString();
                    if (P.ActiveColumns != null)
                    {
                        if (P.ActiveColumns.Select(s => s.ToUpper()).Contains(ColumnName.ToUpper()) != true) continue;
                    }
                    if (new string[] { "VIEW" }.ToList().Contains(ColumnName.ToUpper()))
                    {
                        ColumnName = "[" + ColumnName + "]";
                    }
                    if (ColumnName.StartsWith("$")) ColumnName = "[" + ColumnName + "]";
                    if (dataType == typeof(string) || dataType == typeof(String))
                    {
                        list.Add(" (" + ColumnName + " LIKE '%" + searchValue + "%')");
                    }
                    else
                    {

                        list.Add("(CAST(" + ColumnName + " AS VARCHAR(100)) LIKE '%" + searchValue + "%')");
                    }
                }
                if (list.Count > 0)
                {
                    SQL += " AND (" + String.Join(" OR ", list) + ")";
                }
            }

            if (String.IsNullOrEmpty(Value) != true)
            {
                if (SQL.Contains(" WHERE "))
                {
                    SQL = SQL.Substring(0, SQL.IndexOf(" WHERE ")) + " WHERE ( 1 = 1 ) ";
                }
                int tempId = -1;
                var isInt = Int32.TryParse(Value, out tempId);
                primaryKey = isInt ? "ID" : "Oid";
                if (isInt == false) Value = $"'{Value}'";
                SQL += $" AND {primaryKey} =  {Value} ";
            }

            if (skip != null && take != null && primaryKey == null)
            {
                primaryKey = "ID";
            }


            List<JToken> sortToken = null;
            if (sort != null)
            {
                sortToken = JArray.Parse(sort).ToList<JToken>();
            }

            string Sorting = null;
            if (groupsColumns.Length > 0)
            {
                var groupSort = new List<string>();
                if (sortToken != null)
                {
                    foreach (var g in groupsColumns)
                    {
                        var gc = sortToken.SingleOrDefault(s => s["dataField"].ToString() == g);
                        var isDesc = gc != null ? (bool)gc["isDesc"] == true : false;
                        groupSort.Add(g + " " + (isDesc ? "DESC" : ""));
                    }
                    Sorting += String.Join(", ", groupSort);
                }
                else
                {
                    Sorting += String.Join(", ", groupsColumns);
                }
            }

            if (sortToken != null)
            {
                if (Sorting == null) Sorting = "";
                if (sortToken.Count > 0)
                {
                    var origSort = (string.Join(",", sortToken.Where(s => groupsColumns.Contains(s["dataField"].ToString()) == false).Select(s => s["dataField"].ToString() + (((bool)s["isDesc"]) == true ? " DESC" : ""))));
                    if (origSort.Trim().Length > 0 && Sorting.Length > 0)
                    {
                        Sorting += (", " + origSort);
                    }
                    else
                    {
                        Sorting += origSort;
                    }
                }
            }

            if (Sorting != null)
            {
                OrderBy = "ORDER BY " + Sorting;
                SQL += " " + OrderBy;
            }
            else
            {
                if (OrderBy != null)
                {
                    SQL += " " + OrderBy;
                }
            }

            //var rand = new Random();
            //string strNumber = rand.Next(1000, 9999).ToString();

            //SQL = $"SELECT [{strNumber}].* FROM ({SQL}) [{strNumber}] WHERE 1 = 1";

            if (skip != null && take != null && primaryKey != null)
            {
                //
                //
                //
                string SummaryColumns = null;
                var SummaryList = new List<string>();
                SummaryList.Add("ISNULL(COUNT('" + primaryKey + "'),0) AS RecordCount");
                if (SummaryColumns != null && skip == 0)
                {
                    SummaryList.AddRange(
                        ((JArray)SummaryColumns).ToList<JToken>().Select(s => "ISNULL(" + s["summaryType"] + "(" + s["dataField"] + "),0.00) AS " + s["dataField"]).ToList<String>()
                    );
                }
                var summaries = GetQueryTotals(SQL, SummaryList);
                List<dynamic> GroupTotals = null;
                if (groupsColumns.Length > 0 && skip == 0)
                {
                    var groups = groupsColumns.Select(s => $"{s} AS [{s}], ISNULL(COUNT(*),0) AS [{s}_Count]").ToList();
                    GroupTotals = GetQueryTotals(SQL, groups, groupsColumns);
                }
                if (OrderBy != null)
                {
                    SQL = SQL + " OFFSET " + skip + " ROWS FETCH NEXT " + take + " ROWS ONLY";
                }
                else
                {
                    SQL = SQL + " ORDER BY " + primaryKey + " DESC OFFSET " + skip + " ROWS FETCH NEXT " + take + " ROWS ONLY";
                }
                result = new PagingResult()
                {
                    Summaries = summaries,
                    Data = JSCommon.SQL.GetDataTable(SQL).ToDynamic(),
                    GroupTotals = GroupTotals
                };
            }
            else
            {
                result = new PagingResult()
                {
                    Data = JSCommon.SQL.GetDataTable(SQL).ToDynamic()
                };
            }
            return result;
        }

        //private string getFilterString(JArray values)
        //{
        //    var sb = new StringBuilder();
        //    foreach (var v in values)
        //    {
        //        var _v = v.ToString();
        //        if (v.GetType() == typeof(JArray))
        //        {

        //        }
        //        if (v.GetType() == typeof(JValue))
        //        {

        //        }
        //        Console.WriteLine(v.GetType().Name);
        //    }

        //    for (int i = 0; i < values.Count; i++)
        //    {
        //        var v = values[i];
        //        if (v.GetType() == typeof(JArray))
        //        {
        //            sb.Append(" (" + getFilterString((JArray)v) + ") ");
        //        }
        //        else if (v.GetType() == typeof(JValue))
        //        {
        //            var o = ((JValue)v).Value;
        //            if (o == null) continue;
        //            if (i % 2 == 1)
        //            {
        //                var Optr = o.ToString();
        //                switch (Optr)
        //                {
        //                    case "contains":
        //                    case "startswith":
        //                    case "endswith":
        //                        sb.Append(" LIKE ");
        //                        break;
        //                    default:
        //                        sb.Append(" " + ((string)o).ToUpper() + " ");
        //                        break;
        //                }
        //            }
        //            if (i == 0)
        //            {
        //                sb.Append(" " + o.ToString() + " ");
        //            }
        //            else if (i == 2)
        //            {
        //                if (o.GetType() == typeof(string))
        //                {
        //                    string Optr = values[1].ToString();
        //                    var stringValue = ((string)o).Replace("'", "''");
        //                    switch (Optr)
        //                    {
        //                        case "contains":
        //                            sb.Append(" '%" + stringValue + "%' ");
        //                            break;
        //                        case "startswith":
        //                            sb.Append(" '%" + stringValue + "' ");
        //                            break;
        //                        case "endswith":
        //                            sb.Append(" '" + stringValue + "%' ");
        //                            break;
        //                        default:
        //                            sb.Append(" '" + stringValue + "' ");
        //                            break;
        //                    }
        //                }
        //                else if (o.GetType() == typeof(bool))
        //                {
        //                    if ((bool)o == true)
        //                    {
        //                        sb.Append("1");
        //                    }
        //                    else if ((bool)o == false)
        //                    {
        //                        sb.Append("0");
        //                    }
        //                }
        //                else if (o.GetType() == typeof(DateTime))
        //                {
        //                    sb.Append(((DateTime)o).ToString("YYYY-MM-DD"));
        //                }
        //                else
        //                {
        //                    sb.Append(o.ToString());
        //                }
        //            }
        //        }
        //    }

        //    return sb.ToString();
        //}

        private List<dynamic> GetQueryTotals(string SQL, List<string> FieldSummaries, string[] groupColumns = null)
        {
            if (SQL.ToUpper().IndexOf(" ORDER ") > -1)
            {
                //SQL = "SELECT " + String.Join(",", FieldSummaries) + " " + SQL.Substring(SQL.ToUpper().IndexOf("FROM"), SQL.ToUpper().IndexOf(" ORDER ") - 9 );
                //SQL.ToUpper().IndexOf(" ORDER ") - SQL.ToUpper().IndexOf("FROM")
                SQL = "SELECT " + String.Join(",", FieldSummaries) + " " + SQL.Substring(SQL.ToUpper().IndexOf("FROM"), SQL.ToUpper().IndexOf(" ORDER ") - SQL.ToUpper().IndexOf("FROM"));
            }
            else
            {
                SQL = "SELECT " + String.Join(",", FieldSummaries) + " " + SQL.Substring(SQL.ToUpper().IndexOf("FROM"));
            }

            if (groupColumns != null)
            {
                SQL += $" GROUP BY " + string.Join(",", groupColumns) + " ORDER BY " + string.Join(",", groupColumns);
            }

            return new DBCollection().GetDynamicCollections(SQL);
        }
    }

    public class PagingResult
    {
        public List<dynamic> Data { get; set; }
        public List<dynamic> Summaries { get; set; }

        public List<dynamic> GroupTotals { get; set; }
        public string SQL { get; set; }
    }

    public class PagingParams
    {
        public string SQL { get; set; }
        public int? Skip { get; set; }
        public string Value { get; set; }
        public int? Take { get; set; }
        public string PrimaryKey { get; set; }
        public string FilterOption { get; set; }
        public string SortingOption { get; set; }
        public string SummaryOption { get; set; }
        public string GroupOptions { get; set; }
        public string SearchValue { get; set; }
        public string[] ActiveColumns { get; set; }
        public string filterFormValue { get; set; }
        //public string _DataSource { get; set; }
    }
}
