using Nancy.Json;
using Newtonsoft.Json.Linq;
using ngJSApp;
using ngJSApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace JSLibrary {

    public class DBCollection : IDisposable {

        public SqlConnection sqlConn;

        public DBCollection() {

            string DBConnectionString = Startup.DBConnectionString;
            string result = DBCollection.GetReplacedConnectionString(DBConnectionString);

            sqlConn = new SqlConnection(Startup.DBConnectionString);
        }

        public static bool HasProperty(dynamic obj, string name)
        {
            Type objType = obj.GetType();

            if (objType == typeof(ExpandoObject))
            {
                return ((IDictionary<string, object>)obj).ContainsKey(name);
            }

            return objType.GetProperty(name) != null;
        }

        public DBCollection(string DBConnectionString)
        {
            string result = DBCollection.GetReplacedConnectionString(DBConnectionString);

            sqlConn = new SqlConnection(DBConnectionString);
        }

        static public string GetReplacedConnectionString(string DBConnectionString)
        {
            if (DBConnectionString == null) DBConnectionString = "";

            string result = DBConnectionString;
            result = result.Replace("/*User id*/", "sa");
            result = result.Replace("/*Password*/", "sql123$%^");

            return result;
        }

        public List<dynamic> GetDynamicCollections(string SQL) {
            var dataTable = GetDataTable(SQL, sqlConn);
            if (dataTable.Rows.Count == 0) return null;
            var DynamicList = new List<dynamic>();
            var ColumnNames = dataTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow row in dataTable.Rows) {
                IDictionary<string, object> currentObject = new ExpandoObject();
                foreach (var columnName in ColumnNames) {
                    if (row[columnName] == DBNull.Value) {
                        currentObject.Add(columnName,null);
                    } else {
                        currentObject.Add(columnName, row[columnName]);
                    }
                    
                }
                DynamicList.Add(currentObject);
            }
            return DynamicList;
        }

        public string ToJson(string SQL) {
            return JsonHelper.JsonCompress(GetDataTable(SQL, sqlConn, null));
        }

        public string GetJsonObject(string SQL, params string[] DataSetNames) {
            var DataSets = GetDataSet(sqlConn, SQL);
            if (DataSets.Tables.Count == 0) return null;
            if (DataSets.Tables.Count == 1) {
                var dataTable = DataSets.Tables[0];
                if (DataSetNames.Length > 0) {
                    var rows = JsonHelper.GetRows(dataTable);
                    for (int i = 0; i < DataSetNames.Length; i++) {
                        var r = new Dictionary<string, object>();
                        r.Add(DataSetNames[i], "[]");
                        rows.Add(r);
                    }
                    if (dataTable.Rows.Count == 0) return null;
                    JavaScriptSerializer _serializer = new JavaScriptSerializer();
                    //_serializer.MaxJsonLength = Int32.MaxValue;
                    return _serializer.Serialize(rows);
                }
                if (dataTable.Rows.Count == 0) return null;
                return JsonHelper.ConvertDataTabletoString(DataSets.Tables[0]);
            }
            var DictionaryRows = JsonHelper.GetRows(DataSets.Tables[0]);
            for (int i = 1; i < DataSets.Tables.Count; i++) {
                var JSONString = JsonHelper.JsonCompress(DataSets.Tables[i]);
                var Row = new Dictionary<string, object>();
                Row.Add(DataSetNames[i - 1], JSONString);
                DictionaryRows.Add(Row);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = Int32.MaxValue;
            string mResult = serializer.Serialize(DictionaryRows);
            //string Original = null;
            //try
            //{
            //    List<Dictionary<string, object>>  unpacked = serializer.Deserialize<List<Dictionary<string, object>>>(mResult);
            //    Original = serializer.Serialize(JsonHelper.pack(unpacked, 0));
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}
            return mResult;
        }

        public static DataTable GetDataTable(string SQL, SqlConnection SqlConn) {
            return GetDataTable(SQL, SqlConn, null);
        }

        public static DataSet GetDataSet(SqlConnection SqlConn, string SQL) {
            if (SQL == null) return null;
            var DataSet = new DataSet();
            using (var SqlCmd = new SqlCommand(SQL, SqlConn)) {
                SqlCmd.CommandType = CommandType.Text;
                new SqlDataAdapter(SqlCmd).Fill(DataSet);
            }
            return DataSet;
        }

        public DataTable getDataTable(string SQL) {
            return GetDataTable(SQL, this.sqlConn);
        }

        public static DataTable GetDataTable(string SQL, SqlConnection SqlConn, SqlTransaction sqlTrans) {
            var dataTable = new DataTable();
            var cmd = new SqlCommand(SQL, SqlConn, sqlTrans);
            var da = new SqlDataAdapter(cmd);
            da.SelectCommand.CommandTimeout = 0;
            da.Fill(dataTable);
            return dataTable;
        }

        public dynamic GetDynamicObject(string SQL, bool IsForceEncrypt = true) {
            return _GetDynamicObject(this.sqlConn, SQL, IsForceEncrypt);
        }

        public static dynamic _GetDynamicObject(SqlConnection sqlConn, string SQL, bool isForceEncrypt = true) {
            var DataSet = GetDataSet(sqlConn, SQL);
            if (DataSet.Tables.Count == 0) return null;
            var ObjectDetailPropertyNames = (from c in DataSet.Tables[0].Columns.Cast<DataColumn>()
                                             select c.ColumnName).ToList();

            var dtSchema = DataSet.Tables[0] as DataTable;

            int i = 1;

            var _List = GetDynamicObjectList(DataSet.Tables[1], isForceEncrypt);

            IDictionary<string, object> dynamicObject = null;

            if ( _List == null ) throw new Exception("Current Object not found");

            if (_List.Count == 0) throw new Exception("Current Object not found");

            dynamicObject = _List.Single();

            foreach (DataColumn c in dtSchema.Columns) {
                if (c.ColumnName == "_") continue;
                if ((string)dtSchema.Rows[0][c] == "_") continue;
                string LinkProperty = (string)dtSchema.Rows[0][c.ColumnName];
                if (String.IsNullOrEmpty(LinkProperty.ToString().Trim())) {
                    dynamicObject.Add(ObjectDetailPropertyNames[i], GetDynamicObjectList(DataSet.Tables[i + 1], isForceEncrypt));
                    //dynamicObject.Add(ObjectDetailPropertyNames[i -1], GetDynamicObjectList(DataSet.Tables[i]));
                } else {
                    //
                    //  CHILDS
                    //

                    var childDataTable = GetDynamicObjectList(DataSet.Tables[i + 1], isForceEncrypt);

                    if (childDataTable == null) continue;

                    string ParentTableName = LinkProperty.Split('.')[0];

                    string LinkPropertyName = LinkProperty.Split('.')[1];

                    string ParentColumnName = "";

                    if (LinkProperty.Count(lp => lp == '.') > 1) {
                        ParentColumnName = LinkProperty.Split('.')[2];
                    }

                    List<dynamic> DynamicObjects = (List<dynamic>)dynamicObject[ParentTableName];

                    if (DynamicObjects != null) {
                        foreach (dynamic d in DynamicObjects) {

                            int id = d.ID;

                            if (ParentColumnName.Length > 0) {
                                id = (Int32)((IDictionary<string, object>)d)[ParentColumnName];
                            }


                            var List = childDataTable.Where(cd => (Int32)((IDictionary<string, object>)cd)[LinkPropertyName] == id).ToList();

                            ((IDictionary<string, object>)d).Add(c.ColumnName, List.Count > 0 ? List : new List<dynamic>());

                        }
                    }

                }
                i++;
            }
            return dynamicObject;
        }


        public static List<dynamic> GetDynamicObjectList(DataTable MainTable,bool isForceEncrypt = true) {
            if (MainTable.Rows.Count == 0) return null;
            var dynamicList = new List<dynamic>();
            var MainObjectProperties = (from c in MainTable.Columns.Cast<DataColumn>()
                                        select c.ColumnName).ToList();
            if (MainTable.Rows.Count == 0) return null;

            List<string> MainProperties = MainObjectProperties.Where(s => s.IndexOf('^') == -1).ToList();
            List<string> ForeignKeyColumns = MainObjectProperties.Where(s => s.IndexOf('^') > -1).ToList();
            List<string> ForeignKeyProperties = new List<string>();
            foreach (string foreignKey in ForeignKeyColumns) {
                var CharIndex = foreignKey.IndexOf("_") - 1;
                if (!ForeignKeyProperties.Contains(foreignKey.Substring(1, CharIndex))) {
                    ForeignKeyProperties.Add(foreignKey.Substring(1, CharIndex));
                }
            }

            foreach (DataRow dr in MainTable.Rows) {
                IDictionary<string, object> dynamicObject = new ExpandoObject();

                foreach (string column in MainObjectProperties) {
                    if (column.IndexOf('^') == 0) {
                        foreach (string s in ForeignKeyProperties) {
                            var characterIndex = column.IndexOf('_');
                            if (s == column.Substring(1, characterIndex - 1)) {
                                var columnName = column.Substring(characterIndex + 1, column.Length - (characterIndex + 1));
                                if (dynamicObject.Keys.Where(cn => cn.Equals(s)).ToList().Count == 0) {
                                    if (dr["^" + s + "_ID"] != null) {
                                        dynamicObject.Add(s, new ExpandoObject());
                                        //((IDictionary<string, object>)dynamicObject[s]).Add("ID", dr["^" + s + "_ID"]);
                                    } else {
                                        dynamicObject[s] = null;
                                    }
                                }
                                if (dynamicObject[s] != null) {
                                    ((IDictionary<string, object>)dynamicObject[s]).Add(columnName, dr.IsNull(column) ? null : dr[column]);
                                }
                            }
                        }
                    } else {
                        var value = dr[column];
                        if (value != null && value != DBNull.Value) {
                            if (column.IndexOf('$') == 0) {
                                if (value.GetType() == typeof(String)) {
                                    //encrypt value
                                    //if (isForceEncrypt) {
                                    //    value = Utils.Encrypt(value.ToString());
                                    //}
                                    value = Utils.Encrypt(value.ToString());
                                    //column = column.Substring(1);
                                }
                            }
                        }
                        string _column = column.IndexOf('$') == 0 ? column.Substring(1) : column;
                        if (dynamicObject.Keys.Contains(_column) == false) {
                            dynamicObject.Add(_column, dr.IsNull(column) ? null : value);
                        }
                        //if (dynamicObject.Keys.Contains(column)) {
                        //    dynamicObject[column] = value;
                        //} else {
                        //    string _column = column.IndexOf('$') == 0 ? column.Substring(1) : column;
                        //    dynamicObject.Add(_column, dr.IsNull(column) ? null : value);
                        //}
                    }
                }
                dynamicObject.Add("_IsNew", false);
                dynamicList.Add(dynamicObject);
            }
            return dynamicList;
        }

        //public List<T> GetCollection<T>(String SQL) {
        //    try {
        //        Type t = typeof(T);
        //        DataTable dataTable = GetDataTable(SQL, this.sqlConn);
        //        if (dataTable.Rows.Count == 0)
        //            return null;
        //        List<T> mList = new List<T>();
        //        foreach (DataRow R in dataTable.Rows) {
        //            T newObject = (T)Activator.CreateInstance(t);
        //            foreach (PropertyInfo f in t.GetProperties()) {
        //                DBColumnAttribute dbField = f.GetCustomAttribute<DBColumnAttribute>();
        //                if (dbField == null)
        //                    continue;
        //                String FieldName = dbField.Name == null ? f.Name : dbField.Name;
        //                if (dataTable.Columns.Contains(FieldName) == false) continue;
        //                Object Value = R[FieldName];
        //                if (Value == null)
        //                    continue;
        //                if (Value.GetType() == typeof(DBNull))
        //                    continue;
        //                f.SetValue(newObject, Value);
        //            }
        //            mList.Add((T)newObject);
        //        }
        //        return mList;
        //    } catch (SqlException e) {
        //        throw new JsAppException(e.Message, e.LineNumber);
        //    } finally {
        //        sqlConn.Close();
        //    }
        //}

        public void Dispose() {
            try {
                System.GC.Collect();
            } catch { }
        }


        //
        //
        //

        public static object GetCurrentObject(dynamic Session,string SQL, string ID_CurrentObject, string Params = null) {
             return _ExecSQLProc(Session, SQL, Params, ID_CurrentObject, true);
        }

        public static object _ExecSQLProc(dynamic CurrentUser, string SQL, string Params, string ID_CurrentObject, bool IsReturnObject = true, bool IsTransaction = false) {
            //dynamic CurrentUser = Session["CurrentUser"] as dynamic;
            bool IsNew = false;
            bool isID = false;
            try{
                IsNew = Int32.Parse(ID_CurrentObject) == -1;
                isID = true;
            } catch {
                IsNew = ID_CurrentObject == null;
                isID = false;
            }

            dynamic CurrentObject = null;
            List<SqlParameter> ProcParameters = null;
            if (Params != null) {
                
                List<dynamic> Parameters = GetProcedureParameters(SQL);

                JObject dParams = JObject.Parse(Params);
                if (IsReturnObject) {
                    if (IsNew == false) {
                        if (dParams.Properties().Select(p => p.Name).ToList().Contains((isID == false ? "Oid" : "ID")) == false) dParams.Add((isID == false ? "Oid" : "ID"), ID_CurrentObject);
                    }
                }
                var properties = dParams.Properties();
                ProcParameters = new List<SqlParameter>();
                if (Parameters != null) {
                    foreach (var p in Parameters) {

                        if (p.system_type_id == 243) //USER DEFINE TYPES
                        {
                            var sqlParam = new SqlParameter();
                            sqlParam.SqlDbType = SqlDbType.Structured;
                            sqlParam.ParameterName = p.Name;

                            var ArrayParams = (JArray)dParams[p.Name.Replace("@", "")];
                            if (ArrayParams == null) continue;
                            if (ArrayParams.Count > 0) {
                                var dtParams = new DataTable();
                                string[] UserTypeParameters = ((String)p.TypeParameters).Split(new char[] { ',' }).ToArray();

                                foreach (string param in UserTypeParameters) {

                                    int ID_Type = Int32.Parse(param.Split(new char[] { '$' })[1]);
                                    string Name = param.Split(new char[] { '$' })[0].Trim();
                                    dtParams.Columns.Add(Name, GetTypeByID(ID_Type));

                                }

                                foreach (var obj in ArrayParams) {
                                    var newRow = dtParams.NewRow();
                                    foreach (DataColumn column in dtParams.Columns) {
                                        if (obj.Type.ToString() == "Integer") {
                                            newRow[column.ColumnName] = (int)obj;
                                        } else {
                                            if (obj[column.ColumnName] != null) {
                                                newRow[column.ColumnName] = obj[column.ColumnName];
                                            }
                                        }
                                    }
                                    dtParams.Rows.Add(newRow);
                                }
                                sqlParam.Value = dtParams;
                            }

                            ProcParameters.Add(sqlParam);
                        } else {
                            var sqlParam = new SqlParameter();
                            sqlParam.ParameterName = p.Name;
                            if (p.Name == "@ID_User") {
                                // sqlParam.ParameterName = p.Name;
                                sqlParam.Value = CurrentUser.ID;
                            } else if (p.Name == "@ID_Warehouse" && dParams[p.Name.Replace("@", "")] == null) {
                                //CurrentUser.ID_Warehouse
                            } else if (p.Name == "@ID_Session") {
                                //sqlParam.ParameterName = p.Name;

                                //Type typeOfDynamic = dParams.GetType();
                                bool exist = ((JObject)dParams).Properties().Where(pt => pt.Name.Equals("ID_Session")).Any();
                                //bool exist = typeOfDynamic.GetProperties().Where(pt => pt.Name.Equals("ID_Session")).Any();
                                if (exist) {
                                    //try {
                                    if (((JValue)dParams["ID_Session"]).Value != null) {

                                        sqlParam.Value = Int32.Parse(dParams["ID_Session"].ToString());
                                    } else {
                                        if (CurrentUser != null) sqlParam.Value = CurrentUser.ID_Session;
                                    }


                                    //} catch (Exception e) {
                                    //    sqlParam.Value = CurrentUser.ID_Session;
                                    //}
                                } else {
                                    if (CurrentUser != null) {
                                        sqlParam.Value = CurrentUser.ID_Session;
                                    }
                                }
                                //if (((IDictionary<string, object>)dParams).Keys.Contains("ID_Session")) {
                                //    sqlParam.Value = dParams["ID_Session"];
                                //} else {
                                //    sqlParam.Value = CurrentUser.ID_Session;
                                //}
                            } else if (p.Name == "@ID_Company") {
                                //CurrentUser.ID_Company

                            } else if (p.Name == "@ID") {
                                JValue value = dParams[p.Name.Replace("@", "")];
                                if (value == null) {
                                    sqlParam.Value = -1;
                                } else {
                                    try {
                                        sqlParam.DbType = DbType.Int32;
                                        sqlParam.Value = (Int32)dParams[p.Name.Replace("@", "")];
                                    } catch { }
                                }

                            } else {

                                JValue value = dParams[p.Name.Replace("@", "")];

                                if (value == null) {
                                    sqlParam.Value = DBNull.Value;
                                } else {
                                    if (value.Type == JTokenType.String) {
                                        if (p.Name == "@Oid") {
                                            sqlParam.Value = ((string)dParams[p.Name.Replace("@", "")]).Replace("'", "");
                                        } else {
                                            sqlParam.Value = ((string)dParams[p.Name.Replace("@", "")]);//.Replace("'", "''");
                                        }
                                        
                                    } else if (value.Type == JTokenType.Boolean) {
                                        sqlParam.DbType = DbType.Boolean;
                                        sqlParam.Value = Boolean.Parse(((string)dParams[p.Name.Replace("@", "")]).ToLower());
                                    } else if (value.Type == JTokenType.Integer) {
                                        sqlParam.DbType = DbType.Int32;
                                        sqlParam.Value = (Int32)dParams[p.Name.Replace("@", "")];
                                    } else if (value.Type == JTokenType.Null || value.Type == JTokenType.None) {

                                        sqlParam.Value = DBNull.Value;
                                    } else if (value.Type == JTokenType.Date) {
                                        sqlParam.DbType = DbType.DateTime;
                                        sqlParam.Value = DateTime.Parse(value.ToString());
                                    }

                                }


                            }

                            ProcParameters.Add(sqlParam);

                        }


                    }
                }

                

                //foreach (var p in properties)
                //{
                //
                //    Console.Write(dParams[p.Name].GetType().Name);
                //    var pType = dParams[p.Name].GetType();
                //    if (pType == typeof(JArray))
                //    {
                //
                //    }
                //}
            }

            if (isID == false) {
                if (ProcParameters == null) {
                    ProcParameters = new List<SqlParameter>();
                    ProcParameters.Add(new SqlParameter("@Oid", new System.Data.SqlTypes.SqlGuid(ID_CurrentObject.Replace("'", ""))) {
                        DbType = DbType.Guid
                    });
                }
            }

            bool isExecSuccess = true;
            using (var sqlConn = JSCommon.GetSQLConnection()) {
                sqlConn.Open();
                SqlTransaction sqlTransaction = null;
               
                if (IsTransaction == true) {
                    if ( sqlTransaction == null ) sqlTransaction = sqlConn.BeginTransaction();
                }

                try
                {
                    var SqlCmd = new SqlCommand(SQL, sqlConn);
                    if (sqlTransaction != null)
                    {
                        SqlCmd.Transaction = sqlTransaction;
                    }
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    if (ProcParameters != null)
                    {
                        foreach (var sqlParams in ProcParameters)
                        {
                            SqlCmd.Parameters.Add(sqlParams);
                        }
                    }

                    if (IsReturnObject)
                    {
                        var DataSet = new DataSet();
                        new SqlDataAdapter(SqlCmd).Fill(DataSet);

                        if (DataSet.Tables.Count == 0 || DataSet.Tables.Count == 1) return null;

                        var ObjectDetailPropertyNames = (from c in DataSet.Tables[0].Columns.Cast<DataColumn>()
                                                         select c.ColumnName).ToList();

                        var dtSchema = DataSet.Tables[0] as DataTable;

                        int i = 1;

                        var _List = GetDynamicObjectList(DataSet.Tables[1], true);

                        IDictionary<string, object> dynamicObject = null;

                        if (_List == null) throw new Exception("Current Object not found");

                        if (_List.Count == 0) throw new Exception("Current Object not found");

                        dynamicObject = _List.Single();

                        foreach (DataColumn c in dtSchema.Columns)
                        {
                            if (c.ColumnName == "_") continue;
                            if ((string)dtSchema.Rows[0][c] == "_") continue;
                            string LinkProperty = (string)dtSchema.Rows[0][c.ColumnName];
                            if (String.IsNullOrEmpty(LinkProperty.ToString().Trim()))
                            {
                                dynamicObject.Add(ObjectDetailPropertyNames[i], GetDynamicObjectList(DataSet.Tables[i + 1], true));
                                //dynamicObject.Add(ObjectDetailPropertyNames[i -1], GetDynamicObjectList(DataSet.Tables[i]));
                            }
                            else
                            {
                                //
                                //  CHILDS
                                //

                                var childDataTable = GetDynamicObjectList(DataSet.Tables[i + 1], true);

                                if (childDataTable == null) continue;

                                string ParentTableName = LinkProperty.Split('.')[0];

                                string LinkPropertyName = LinkProperty.Split('.')[1];

                                string ParentColumnName = "";

                                if (LinkProperty.Count(lp => lp == '.') > 1)
                                {
                                    ParentColumnName = LinkProperty.Split('.')[2];
                                }

                                List<dynamic> DynamicObjects = (List<dynamic>)dynamicObject[ParentTableName];

                                if (DynamicObjects != null)
                                {
                                    foreach (dynamic d in DynamicObjects)
                                    {

                                        int id = d.ID;

                                        if (ParentColumnName.Length > 0)
                                        {
                                            id = (Int32)((IDictionary<string, object>)d)[ParentColumnName];
                                        }


                                        var List = childDataTable.Where(cd => (Int32)((IDictionary<string, object>)cd)[LinkPropertyName] == id).ToList();

                                        ((IDictionary<string, object>)d).Add(c.ColumnName, List.Count > 0 ? List : new List<dynamic>());

                                    }
                                }

                            }
                            i++;
                        }
                        CurrentObject = dynamicObject;


                        if (DBCollection.HasProperty(CurrentObject, "Success") || DBCollection.HasProperty(CurrentObject, "success"))
                        {

                            var dictCurrentObject = (IDictionary<string, object>) CurrentObject; 

                            if (isExecSuccess) {
                                if (dictCurrentObject.ContainsKey("Success"))
                                {

                                    isExecSuccess = (bool) dictCurrentObject["Success"];
                                }
                            }

                            if (isExecSuccess)
                            {
                                if (dictCurrentObject.ContainsKey("success"))
                                {

                                    isExecSuccess = (bool)dictCurrentObject["success"];
                                }
                            }
                        }
                    }
                    else
                    {
                        SqlCmd.ExecuteNonQuery();
                    }


                    if (isExecSuccess != true)
                    {

                        if (sqlTransaction != null) sqlTransaction.Rollback();
                    }
                    else {

                        if (sqlTransaction != null) sqlTransaction.Commit();
                    }
                }
                catch (SqlException e)
                {
                    if (sqlTransaction != null)
                    {
                        sqlTransaction.Rollback();
                    }
                    throw new JsAppException(e.Message, e.Number);
                }
                catch (Exception e)
                {
                    if (sqlTransaction != null)
                    {
                        sqlTransaction.Rollback();
                    }
                    throw new Exception(e.Message);
                }
                //catch (Exception e)  1
                //
                //
                //{
                //    if (AppHub._connections.Count != 0)
                //    {
                //
                //        string ConnectionId = ((IEnumerable<string>)AppHub._connections.GetConnections(Int32.Parse(CurrentUser.ID.ToString()))).First();
                //        var context = GlobalHost.ConnectionManager.GetHubContext<AppHub>();
                //        context.Clients.Client(ConnectionId).onSqlException(e.Message);
                //    }
                //    throw new ApplicationException(e.Message);
                //}
                finally
                {
                    sqlConn.Close();
                    System.GC.Collect();
                }
            }


            return CurrentObject;
        }

        public static List<dynamic> GetProcedureParameters(string ProcedureName) {
            return new DBCollection().GetDynamicCollections("SELECT * FROM _fGetStoredProcedureParameters('" + ProcedureName + "');");
        }

        //
        //
        //

        public static Type GetTypeByID(int type) {

            Type t = null;
            switch (type) {
                case 34: //image
                    t = typeof(String);
                    break;
                case 35: //text
                    t = typeof(String);
                    break;
                case 36: //uniqueidentifier
                    t = typeof(String);
                    break;
                case 40: //date
                    t = typeof(DateTime);
                    break;
                case 41: //time
                    t = typeof(DateTime);
                    break;
                case 42: //datetime2
                    t = typeof(DateTime);
                    break;
                case 43: //datetimeoffset
                    t = typeof(DateTime);
                    break;
                case 48: //tinyint
                    t = typeof(Int32);
                    break;
                case 52: //smallint
                    t = typeof(Int32);
                    break;
                case 56: //int
                    t = typeof(Int32);
                    break;
                case 58: //smalldatetime
                    t = typeof(DateTime);
                    break;
                case 59: //real
                    t = typeof(float);
                    break;
                case 60: //money
                    t = typeof(float);
                    break;
                case 61: //datetime
                    t = typeof(DateTime);
                    break;
                case 62: //float
                    t = typeof(float);
                    break;
                case 98: //sql_variant
                    t = typeof(String);
                    break;
                case 99: //ntext
                    t = typeof(String);
                    break;
                case 104: //bit
                    t = typeof(bool);

                    break;
                case 106: //decimal
                    t = typeof(Decimal);
                    break;
                case 108: //numeric
                    t = typeof(Int32);
                    break;
                case 122: //smallmoney
                    t = typeof(Decimal);
                    break;
                case 127: //bigint
                    t = typeof(Int32);
                    break;
                case 165: //varbinary
                    t = typeof(String);
                    break;
                case 167: //varchar
                    t = typeof(String);
                    break;
                case 173: //binary
                    t = typeof(String);
                    break;
                case 175: //char
                    t = typeof(String);
                    break;
                case 189: //timestamp
                    t = typeof(String);
                    break;
                case 231: //nvarchar
                    t = typeof(String);
                    break;
                case 239: //nchar
                    t = typeof(String);
                    break;
                case 241: //xml
                    t = typeof(String);
                    break;
            }

            return t;
        }
    }
}
