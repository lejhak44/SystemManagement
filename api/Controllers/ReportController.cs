using System;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;
using FastReport.Data;
using ngJSApp.Database;
using Microsoft.EntityFrameworkCore;
using FastReport.Utils;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using ngJSApp.Controllers;
using System.Linq;
using FastReport;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using FastReport.Export.PdfSimple;
using System.Threading.Tasks;
using OfficeOpenXml;
using JSLibrary;
using Newtonsoft.Json;

namespace ngJSApp
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        protected AppDbContext ctx = null;
        public ReportController(AppDbContext _ctx) {
            this.ctx = _ctx;
        }

        [HttpGet("Get/{Oid_Report}")]
        public IActionResult Get(string Oid_Report) {
            var rpt = this.ctx._tReport.SingleOrDefault(d => d.Oid.ToString() == Oid_Report);
            return Ok(rpt);
        }

        [HttpPost("Viewer/{Oid_Report}")]
        public async Task<IActionResult> Viewer(string Oid_Report)
        {

            var webReport = this.GetWebReport(Oid_Report);
            if (webReport == null) return NotFound("Report'" + Oid_Report + "' not found");

            webReport.ShowPreparedReport = false;
            webReport.ShowToolbar = true;


            ViewBag.ID_WebReport = webReport.ID;
            ViewBag.WebReport = webReport;
            return View();
        }

        [HttpPost("PrintHTML/{Oid_Report}")]
        public async Task<IActionResult> PrintHTML(string Oid_Report)
        {
            var webReport = this.GetWebReport(Oid_Report);
            if (webReport == null) return NotFound("Report'" + Oid_Report + "' not found");

            webReport.ShowPreparedReport = false;
            webReport.Report.Prepare(true);

            return webReport.PrintHtml();
        }

        [HttpPost("Excel/{Oid_Report}")]
        public ActionResult Excel(string Oid_Report)
        {
            ExportExcel exportExcelFormat = this.getExportExcelFormat(Oid_Report);
            var dbAccess = new DBCollection();
            var webReport = this.GetInitWebReport(Oid_Report);
            var sql = this.GetWebReportSQLString(webReport);

            
            DataTable dataSource = dbAccess.getDataTable(sql);
            DataView dView = new DataView(dataSource);

            dView.Sort = exportExcelFormat.sort;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
           
            string filePath = "";
            string fullName = "your file name";
            string fileName = "your file name";

            string GuidString = Guid.NewGuid().ToString();

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //excelPackage.Workbook.Properties.Author = "VDWWD";
                //excelPackage.Workbook.Properties.Title = "Title of Document";
                //excelPackage.Workbook.Properties.Subject = "EPPlus demo export data";
                //excelPackage.Workbook.Properties.Created = DateTime.Now;
                //Add some text to cell A1
                //worksheet.Cells["A1"].Value = "My first EPPlus spreadsheet!";
                //You could also use [line, column] notation:
                //worksheet.Cells[1, 2].Value = "This is cell B1!";

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
                int startingRowIndex = 1;

                this.filleExcelWorksheetHeader(ref startingRowIndex, dView, exportExcelFormat, worksheet);

                startingRowIndex++;
                this.generateExcelWorksheetDetailColumns(ref startingRowIndex, exportExcelFormat, worksheet);

                this.fillExcelWorksheetDetail(ref startingRowIndex, dView, exportExcelFormat, worksheet);
                
                startingRowIndex++;
                this.filleExcelWorksheeFooter(ref startingRowIndex, dView, exportExcelFormat, worksheet);

                //Save your file
                FileInfo fi1 = new FileInfo(@"tempfiles/" + webReport.ReportName + "-"+ GuidString + ".xlsx");
                excelPackage.SaveAs(fi1);

                fileName = fi1.Name;
                fullName = fi1.FullName;
                filePath = fi1.DirectoryName;
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(fullName);

            return File(fileBytes, "application/force-download", fileName);
        }

        [HttpPost("Pdf/{Oid_Report}")]
        public async Task<IActionResult> Pdf(string Oid_Report)
        {
            dynamic pdfFile ;
            var webReport = this.GetWebReport(Oid_Report);
            if (webReport == null) return NotFound("Report'" + Oid_Report + "' not found");

            webReport.ShowPreparedReport = false;
            webReport.Report.Prepare();

            using (MemoryStream ms = new MemoryStream())
            {
                PDFSimpleExport pdfExport = new PDFSimpleExport();
                pdfExport.Export(webReport.Report, ms);
                ms.Flush();

                pdfFile = File(ms.ToArray(), "application/pdf", Path.GetFileNameWithoutExtension(webReport.ReportName) + ".pdf");
            }

            return pdfFile;
        }

        ExportExcel getExportExcelFormat(string Oid_Report)
        {
            var rpt = this.ctx._tReport.SingleOrDefault(d => d.Oid.ToString() == Oid_Report);

            ExportExcel exportExcelFormat = new ExportExcel();

            StreamReader r = new StreamReader(@$"App_Data/Report/{rpt.ReportPath}.json");
            string jsonString = r.ReadToEnd();
            ExportExcel _tempObject = JsonConvert.DeserializeObject<ExportExcel>(jsonString);
            
            r.Close();

            return _tempObject;
        }
        void filleExcelWorksheetHeader(ref int startingRowIndex, DataView dataView, ExportExcel exportExcelFormat, ExcelWorksheet worksheet)
        {

            DataTable dataSource = dataView.ToTable();

            if (exportExcelFormat.headerData == null) return;
            if (exportExcelFormat.headerData.Count == 0) return;

            for (int headerDataIndex = 0; headerDataIndex < exportExcelFormat.headerData.Count; headerDataIndex++) {

                ExportExcelHeaderData headerData = exportExcelFormat.headerData[headerDataIndex];
                ExcelRangeBase cellLabel = worksheet.Cells[startingRowIndex, 1];
                ExcelRangeBase cellValue = worksheet.Cells[startingRowIndex, 2];

                cellLabel.Value = headerData.caption.Length > 0 ? headerData.caption : headerData.name;
                cellLabel.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                cellLabel.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                cellLabel.Style.Font.Bold = true;

                cellValue.Value = dataSource.Compute(@"MAX("+ headerData.name + ")", "");
                cellValue.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                cellValue.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;

                startingRowIndex++;
            }
        }
        void filleExcelWorksheeFooter(ref int startingRowIndex, DataView dataView, ExportExcel exportExcelFormat, ExcelWorksheet worksheet)
        {

            DataTable dataSource = dataView.ToTable();

            if (exportExcelFormat.footerData == null) return;
            if (exportExcelFormat.footerData.Count == 0) return;

            for (int footerDataIndex = 0; footerDataIndex < exportExcelFormat.footerData.Count; footerDataIndex++)
            {
                ExportExcelFooterData footerData = exportExcelFormat.footerData[footerDataIndex];
                ExcelRangeBase cellLabel = worksheet.Cells[startingRowIndex, 1];
                ExcelRangeBase cellValue = worksheet.Cells[startingRowIndex, 2];

                cellLabel.Value = footerData.caption.Length > 0 ? footerData.caption : footerData.name;
                cellLabel.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                cellLabel.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                cellLabel.Style.Font.Bold = true;

                cellValue.Value = dataSource.Compute(footerData.expression, "");
                cellValue.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                cellValue.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;

                startingRowIndex++;
            }
        }

        void generateExcelWorksheetDetailColumns(ref int startingRowIndex, ExportExcel exportExcelFormat, ExcelWorksheet worksheet)
        {
            for (int i = 0; i < exportExcelFormat.columns.Count; i++)
            {

                ExportExcelColumn col = exportExcelFormat.columns[i];
                int rowIndex = startingRowIndex;
                int columnIndex = i + 1;
                ExcelRangeBase cell = worksheet.Cells[rowIndex, columnIndex];

                if (col.caption == null) col.caption = "";

                cell.Value = col.caption.Length > 0 ? col.caption : col.name;

                cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                cell.Style.Font.Bold = true;
            }

            startingRowIndex++;
        }

      
        void fillExcelWorksheetDetail(ref int startingRowIndex, DataView dataView, ExportExcel exportExcelFormat, ExcelWorksheet worksheet)
        {

            DataTable dataSource = dataView.ToTable();

            for (int rowIndex = 0; rowIndex < dataSource.Rows.Count; rowIndex++)
            {
                DataRow row = dataSource.Rows[rowIndex];

                for (int columnIndex = 0; columnIndex < exportExcelFormat.columns.Count; columnIndex++)
                {
                    ExportExcelColumn col = exportExcelFormat.columns[columnIndex];
                    ExcelRangeBase cell = worksheet.Cells[startingRowIndex, columnIndex + 1];

                    cell.Value = row[col.name];
                    cell.Style.Numberformat.Format = col.format;
                }

                startingRowIndex++;
            }
        }

        private WebReport GetWebReport(string Oid_Report) {

            var webReport = this.GetInitWebReport(Oid_Report);
            var SQL = this.GetWebReportSQLString(webReport);
            var MainTable = webReport.Report.Dictionary.Connections[0].Tables[0];
            webReport.Report.Dictionary.Connections[0].CommandTimeout = 5000;

            MainTable.SelectCommand = SQL;

            var reportObjects = webReport.Report.AllObjects.ToArray();
            foreach (var rptObj in reportObjects)
            {
                //Console.WriteLine(rptObj.BaseName);
                if (rptObj.GetType() == typeof(FastReport.TextObject))
                {
                    var txtObj = rptObj as TextObject;
                    if (txtObj.Name == "txtCompanyName")
                    {
                        txtObj.Text = "ABC Company";
                    }
                    else if (txtObj.Name == "txtDateGenerated")
                    {
                        txtObj.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    }
                }
            }

            return webReport;
        }

        private WebReport GetInitWebReport(string Oid_Report)
        {
            var rpt = this.ctx._tReport.SingleOrDefault(d => d.Oid.ToString() == Oid_Report);

            if (rpt == null) return null;

            var webReport = new WebReport();

            var filterFormValue = this.Request.Form["filterValue"];
            if (String.IsNullOrEmpty(filterFormValue) != true)
            {
                byte[] data = Convert.FromBase64String(filterFormValue);
                filterFormValue = Encoding.UTF8.GetString(data);
            }
            webReport.Report.Load(@$"App_Data/Report/{rpt.ReportPath}.frx");
            webReport.Mode = WebReportMode.Preview;
            webReport.DesignScriptCode = false;
            webReport.Report.Dictionary.Connections[0].ConnectionString = this.ctx.Database.GetDbConnection().ConnectionString;

            return webReport;
        }
        private string GetWebReportSQLString(WebReport webReport)
        {
            var filterFormValue = this.Request.Form["filterValue"];
            if (String.IsNullOrEmpty(filterFormValue) != true)
            {
                byte[] data = Convert.FromBase64String(filterFormValue);
                filterFormValue = Encoding.UTF8.GetString(data);
            }
            var MainTable = webReport.Report.Dictionary.Connections[0].Tables[0];

            var SQL = MainTable.SelectCommand;
            string where = "";
            var whereClauseList = new List<string>();
            var qClauseList = new Dictionary<string, string>();

            if (SQL.Length == 0) SQL = $"SELECT * FROM {MainTable.TableName}";

            if (String.IsNullOrEmpty(filterFormValue) != true)
            {
                var filterFormValues = JArray.Parse(filterFormValue);

                var filters = from f in filterFormValues
                              where !f["dataField"].Value<string>().Contains("_QPARAM") && !f["dataField"].Value<string>().Contains("_CustomCaption")
                              select f;

                var qParamfilters = from f in filterFormValues
                                    where f["dataField"].Value<string>().Contains("_QPARAM")
                                    select f;

                var customCaptionfilters = from f in filterFormValues
                                           where f["dataField"].Value<string>().Contains("_CustomCaption")
                                           select f;

                foreach (var customCaptionfilter in customCaptionfilters)
                {
                    var dataField = customCaptionfilter["dataField"].Value<string>();
                    var filterCriteriaType = (FilterCriteriaType)Int32.Parse(customCaptionfilter["filterCriteriaType"].Value<string>());
                    var PropertyType = (PropertyTypeEnum)customCaptionfilter["propertyType"].Value<Int32>();
                    var _value = customCaptionfilter["value"];
                    var Values = new List<string>();

                    if (_value.Type == JTokenType.Array)
                    {
                        Values = _value.ToArray<object>().Select(s => s.ToString()).ToList();
                    }
                    else
                    {
                        Values.Add(_value.Value<object>().ToString());
                    }


                    var rptObjs = webReport.Report.AllObjects.ToArray();
                    foreach (var rptObj in rptObjs)
                    {

                        if (rptObj.GetType() == typeof(FastReport.TextObject))
                        {
                            var txtObj = rptObj as TextObject;
                            if (txtObj.Name == "txt" + dataField)
                            {
                                txtObj.Text = (string)Values[0];
                            }
                        }
                    }

                }


                foreach (var qParam in qParamfilters)
                {
                    var dataField = qParam["dataField"].Value<string>();
                    var filterCriteriaType = (FilterCriteriaType)Int32.Parse(qParam["filterCriteriaType"].Value<string>());
                    var PropertyType = (PropertyTypeEnum)qParam["propertyType"].Value<Int32>();
                    var _value = qParam["value"];
                    var Values = new List<string>();

                    dataField = dataField.Replace("_QPARAM", "");

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
                            break;
                        case PropertyTypeEnum.Date:
                        case PropertyTypeEnum.DateTime:
                            if (Values.Count == 1)
                            {
                                Values[0] = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                            }
                            break;
                    }

                    string whereClause = "";

                    switch (filterCriteriaType)
                    {
                        case FilterCriteriaType.Equal:
                            if (PropertyType == PropertyTypeEnum.String)
                            {
                                whereClause = $"{dataField} = '{Values[0].Replace("'", "''")}'";
                            }
                            else if (PropertyType == PropertyTypeEnum.Date)
                            {

                                whereClause = $"CONVERT(DATE,{dataField}) = '{Values[0].Replace("'", "''")}'";
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

                                whereClause = $"CONVERT(DATE,{dataField}) <> '{Values[0].Replace("'", "''")}'";
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
                                whereClause = $"CONVERT(DATE,{dataField}) > '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} > {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.LessThan:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                whereClause = $"CONVERT(DATE,{dataField}) < '{Values[0]}'";
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
                                whereClause = $"CONVERT(DATE,{dataField}) > '{Values[0]}'";
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
                                whereClause = $"CONVERT(DATE,{dataField}) < '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"{dataField} <= {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.Between:

                            bool isStringDate = false;
                            if (PropertyType == PropertyTypeEnum.String)
                            {

                                if (DateTime.TryParse(Values[0], out DateTime theDate))
                                {
                                    isStringDate = true;
                                }
                            }

                            if (isStringDate == true) PropertyType = PropertyTypeEnum.Date;

                            if (PropertyType == PropertyTypeEnum.Date)
                            {

                                var StartDate = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                                var EndDate = DateTime.Parse(Values[1]).ToString("yyyy-MM-dd");

                                whereClause = $"CONVERT(DATE,{dataField})  BETWEEN '{StartDate}' AND '{EndDate}'";
                            }
                            break;
                    }

                    qClauseList.Add("@" + dataField + "_QPARAM", whereClause);
                }

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
                            break;
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

                                whereClause = $"CONVERT(DATE,schema1.{dataField}) = '{Values[0].Replace("'", "''")}'";
                            }
                            else
                            {
                                whereClause = $"schema1.{dataField} = {Values[0].Replace("'", "''")}";
                            }
                            break;
                        case FilterCriteriaType.NotEqual:
                            if (PropertyType == PropertyTypeEnum.String)
                            {
                                whereClause = $"schema1.{dataField} <> '{Values[0].Replace("'", "''")}'";
                            }
                            else if (PropertyType == PropertyTypeEnum.Date)
                            {

                                whereClause = $"CONVERT(DATE,schema1.{dataField}) <> '{Values[0].Replace("'", "''")}'";
                            }
                            else
                            {
                                whereClause = $"schema1.{dataField} <> {Values[0].Replace("'", "''")}";
                            }
                            break;
                        case FilterCriteriaType.Contains:
                            whereClause = $"schema1.{dataField} IN ({string.Join(',', Values)})";
                            break;
                        case FilterCriteriaType.NotContains:
                            whereClause = $"schema1.{dataField} NOT IN ({string.Join(',', Values)})";
                            break;
                        case FilterCriteriaType.Like:
                            whereClause = $"schema1.{dataField} LIKE '%{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.NotLike:
                            whereClause = $"schema1.{dataField} NOT LIKE '%{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.StartWith:
                            whereClause = $"schema1.{dataField} NOT LIKE '{Values[0].Replace("'", "''")}%'";
                            break;
                        case FilterCriteriaType.EndWith:
                            whereClause = $"schema1.{dataField} NOT LIKE '%{Values[0].Replace("'", "''")}'";
                            break;
                        case FilterCriteriaType.GreaterThan:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                whereClause = $"CONVERT(DATE,schema1.{dataField}) > '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"schema1.{dataField} > {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.LessThan:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                whereClause = $"CONVERT(DATE,schema1.{dataField}) < '{Values[0]}'";
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
                                whereClause = $"CONVERT(DATE,schema1.{dataField}) > '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"schema1.{dataField} >= {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.LessThanEqual:
                            if (PropertyType == PropertyTypeEnum.Date)
                            {
                                Values[0] = DateTime.Parse(Values[0]).AddDays(1).ToString("yyyy-MM-dd");
                                whereClause = $"CONVERT(DATE,{dataField}) < '{Values[0]}'";
                            }
                            else
                            {
                                whereClause = $"schema1.{dataField} <= {Values[0]}";
                            }
                            break;
                        case FilterCriteriaType.Between:

                            bool isStringDate = false;
                            if (PropertyType == PropertyTypeEnum.String)
                            {

                                if (DateTime.TryParse(Values[0], out DateTime theDate))
                                {
                                    isStringDate = true;
                                }
                            }

                            if (isStringDate == true) PropertyType = PropertyTypeEnum.Date;

                            if (PropertyType == PropertyTypeEnum.Date)
                            {

                                var StartDate = DateTime.Parse(Values[0]).ToString("yyyy-MM-dd");
                                var EndDate = DateTime.Parse(Values[1]).ToString("yyyy-MM-dd");

                                whereClause = $"CONVERT(DATE,schema1.{dataField})  BETWEEN '{StartDate}' AND '{EndDate}'";
                            }
                            break;
                    }
                    whereClauseList.Add($"({whereClause})");
                }

                if (qClauseList.Count > 0)
                {

                    foreach (var qParam in qClauseList)
                    {
                        whereClauseList.Add(qParam.Value);
                    }
                }
            }

            where += String.Join(" AND ", whereClauseList);
            if (SQL.Contains("/*@WHERE*/") || SQL.Contains("/*@WHERE1*/"))
            {
                string where1 = where.Replace("schema1.", "where1.");
                string where2 = where.Replace("schema1.", "where2.");
                where = where.Replace("schema1.", "");

                SQL = SQL.Replace("/*@WHERE*/", " WHERE " + where);
                SQL = SQL.Replace("/*@WHERE1*/", " WHERE " + where1); ;
                SQL = SQL.Replace("/*@WHERE2*/", " WHERE " + where2);
            }
            else
            {
                where = where.Replace("schema1.", "");
                SQL += !SQL.Contains("/*@WHERE*/") ? "/*@WHERE*/" : "";
                SQL = SQL.Replace("/*@WHERE*/", " WHERE " + where);
            }

            return SQL;
        }
    }
    public class PayLoad
    {
        public string filterValue { get; set; }
    }

    public class ExportExcel
    {
        public string ReportFileName { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string? sort { get; set; }

        public List<ExportExcelHeaderData> headerData = new List<ExportExcelHeaderData>();
        public List<ExportExcelColumn> columns = new List<ExportExcelColumn>();
        public List<ExportExcelFooterData> footerData = new List<ExportExcelFooterData>();
    }

    public class ExportExcelColumn
    {
        public string name { get; set; }
        public string? caption { get; set; }
        public string? dataType { get; set; }
        public string? format { get; set; }
    }

    public class ExportExcelHeaderData
    {
        public string name { get; set; }
        public string? caption { get; set; }
        public string? dataType { get; set; }
        public string? format { get; set; }
    }
    public class ExportExcelFooterData
    {
        public string name { get; set; }
        public string? caption { get; set; }
        public string? expression { get; set; }
        public string? dataType { get; set; }
        public string? format { get; set; }
    }


    public enum FilterCriteriaType 
    {
        Exclude = 0,
        Equal = 1,
        NotEqual = 2,
        Contains = 3,
        NotContains = 4,
        Like = 5,
        NotLike = 6,
        StartWith = 7,
        EndWith = 8,
        GreaterThan = 9,
        LessThan = 10,
        GreaterThanEqual = 22,
        LessThanEqual = 23,
        Between = 13
    }

   public enum PropertyTypeEnum
    {
        String = 1,
        Int = 2,
        Decimal = 3,
        Bit = 4,
        DateTime = 5,
        Date = 6,
        Time = 7,
        Uniqueidentifier = 8,
        Object = 9,
        List = 10,
        Color = 11,
        Image = 12
    }

}