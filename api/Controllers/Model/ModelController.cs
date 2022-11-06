using JSLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ngJSApp.Database;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ngJSApp.Controllers
{

    //[EnableCors("AllowAll")]
    [CustomAuthorize]
    [Route("api/[controller]")]
    [ApiController]
    public partial class ModelController : BaseApiController
    {

        IAppCrypterService crypterService;
        public ModelController(AppDbContext ctx, IWebHostEnvironment env,IAppCrypterService crypterService, IConfiguration _Configuration) : base(ctx,env, crypterService, _Configuration) {

            this.crypterService = crypterService;
        }

        [HttpPost]
        [Route("GetList/{OidModel}")]
        public ActionResult GetList(string OidModel, PagingParams p)
        {

            PagingResult res = null;
            string SQL = p.SQL;
            if (String.IsNullOrWhiteSpace(SQL))
            {
                var model = this.ctx._vListView.SingleOrDefault(d => d.Oid.ToString() == OidModel);
                if (model == null) throw new Exception($"{OidModel} not found. Please check DB");
                if (string.IsNullOrWhiteSpace(model.DataSource)) throw new Exception($"{model.Name} ViewSource not set");
                p.SQL = model.DataSource;
                p.PrimaryKey = model.PrimaryKey;
                res = this.GetPagingResult(p);
            }
            else {
                p.SQL = this.appCrypter.Decrypt(SQL);
                //p.SQL = Utils.Decrypt(SQL);
                res = this.GetPagingResult(p);
                //res.SQL = Utils.Encrypt(SQL);
            }
            return Ok(res);
        }

        [HttpPost]
        [Route("LoadObject/{ID_CurrentObject}")]
        public ActionResult LoadObject(string ID_CurrentObject, LoadObjectParam P)
        {
            var model = ctx._tModel.SingleOrDefault(d => d.Oid.ToString() == P.Oid_Model);
            var modelName = model.Name;
            int Id = -1;
            bool isInt = Int32.TryParse(ID_CurrentObject, out Id);
            string SQL = null;
            object CurrentObject = null;
            var procList = ctx._vModelGetProcedures.Where(s => s.name.Contains($"pGet{modelName}")).ToList();
            if (procList.Count > 0) {
                SQL = $"pGet{modelName}";
                CurrentObject = DBCollection.GetCurrentObject(null, SQL, ID_CurrentObject, P.Params);
            } else
            {
                if (isInt && !(Id > 0)) {
                    return Ok(new { });
                }
                string tableName = model.TableName;
                if (ctx._vModelViews.Where(s => s.Name.Contains($"v{modelName}")).Count() > 0)
                {
                    tableName = $"v{modelName}";
                }
                SQL = $"SELECT * FROM {tableName} WHERE [" + (isInt ? "id" : "Oid") + "] = " + (isInt ? ID_CurrentObject : $"'{ID_CurrentObject}'");
                CurrentObject = this.Query(SQL)[0];
            } 
            return Ok(CurrentObject);
        }

        [HttpPost]
        [Route("Query")]
        public ActionResult Query(PagingParams p)
        {
            var SQL = this.appCrypter.Decrypt(p.SQL);
            //var _sql = Utils.Decrypt(SQL);
            var list = Query(SQL);
            return Ok(list);
        }


        [HttpPost]
        [Route("Save/{Oid_Model}")]
        public ActionResult SaveObject(string Oid_Model,[FromForm]SaveObjectParam p, [FromForm]IFormFileCollection files) {
            var key = this.Save(Oid_Model, p, files);
            return Ok(new { 
                key
            });
        }

        public string CurrentObject { get; set; }
        public string PreviousObject { get; set; }
        public string DeletedItems { get; set; }
        public string UploadFileDetails { get; set; }
        public string CurrentUser { get; set; }
        public string Param { get; set; }

        [AllowAnonymous]
        [HttpPost]
        [Route("Save2/{Oid_Model}")]
        public ActionResult SaveObject2(string Oid_Model, [FromForm] string param, [FromForm] IFormFileCollection files)
        {
            SaveObjectResult saveObjResult = new SaveObjectResult();
            SaveObjectParam p = new SaveObjectParam();

            string decryptedString = this.appCrypter.Decrypt(param);
            dynamic obj = JObject.Parse(decryptedString);

            p.CurrentObject = obj.CurrentObject;
            p.PreviousObject = obj["PreviousObject"];
            p.DeletedItems = obj["DeletedItems"];
            p.UploadFileDetails = obj["UploadFileDetails"];
            p.CurrentUser = obj["CurrentUser"];

            var key = "";
            var message = "";
            ExpandoObject record = null;

            try
            {
                saveObjResult = this._Save(Oid_Model, p, files);
            }
            catch (Exception ex) {

                message = ex.Message;
            }

            key = saveObjResult.ID_CurrentObject;
            message = saveObjResult.Message;
            record = saveObjResult.Record;

            return Ok(new
            {
                key,
                message,
                record
            });
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SavingAPI")]
        public ActionResult SavingAPI(SavingParams s)
        {
            SaveObjectParam p = new SaveObjectParam();

            dynamic obj = JObject.Parse(s.Params);

            p.CurrentObject = obj.CurrentObject;
            p.PreviousObject = obj["PreviousObject"];

            try
            {
                var key = this.Save(s.Oid_Model, p);

                return Ok(new
                {
                    key
                });
            }
            catch (Exception ex) {

                var message = ex.Message;

                return Ok(new {

                   message
                });
            }
        }


        [HttpPost]
        [Route("UploadFiles/{Oid_Model}")]
        public async System.Threading.Tasks.Task<ActionResult> UploadFilesAsync(string Oid_Model, [FromForm] SaveObjectParam p, [FromForm] IFormFileCollection files)
        {
            var filename = await this.UploadAsync(Oid_Model, p, files);

            return Ok(new
            {
                filename
            });
        }

        [HttpPost]
        [Route("SOAPLabSendEmail/{soapID}")]
        public async System.Threading.Tasks.Task<ActionResult> SOAPLabSendEmail(int soapID)
        {
            bool Success = true;
            string message = "";

            try
            {

                //IMBCModule.Patient_SOAP.SendLaboratoryImage(soapID);
            }
            catch (Exception ex) {

                Success = false;
                message = ex.Message;
            }

            return Ok(new
            {
                Success,
                message
            });
        }


        [HttpPost]
        [Route("SendText")]
        public async System.Threading.Tasks.Task<ActionResult> SendTextMessage([FromForm]string data) {

            dynamic json = JsonConvert.DeserializeObject(data);
            dynamic CurrentObject = JObject.Parse(json);
            dynamic numbers = CurrentObject["CellPhoneNumbers"];

            Dictionary<string, bool> PhoneNumberStatus = new Dictionary<string, bool>();

            foreach (string number in numbers)
            {
                if (!PhoneNumberStatus.ContainsKey(number)) {

                    string Message = CurrentObject["Message"];
                    string itexMoAPICode = _Configuration.GetValue<string>("ITexMoAPICode");
                    string itexMoAPIPassword = _Configuration.GetValue<string>("ITexMoAPIPassword");

                    dynamic result = Utility.sendTextMessage(number, Message, itexMoAPICode, itexMoAPIPassword);

                    bool isSent = (result == "0");

                    PhoneNumberStatus.Add(number, isSent);
                }
            }

            return Ok(new
            {
                PhoneNumberStatus
            });
        }

        [HttpGet]
        [Route("DetailView/{Oid}")]
        public ActionResult GetDetailView(string Oid)
        {
            bool isDebug = true;
#if DEBUG == false
            isDebug = false;
#endif
            IDictionary<string, object> dataSources = new ExpandoObject();
            var selectBoxes = ctx._tDetailView_Detail.Where(d =>d.ID_DetailView.ToString() == Oid && d.ID_ControlType == (int)ControlTypeEnum.SelectBox && d.DataSource != null && d.IsLoadData == true).ToList();
            foreach (var d in selectBoxes)
            {
                var list = this.Query(d.DataSource);
                dataSources[d.Name] = list;
            }
            var DetailView = new DBCollection().GetDynamicObject("EXEC dbo._pGetDetailViewWithDetails @Oid = \"" + Oid + "\"", !isDebug);
            if (selectBoxes.Count > 0) {
                ((IDictionary<string, object>)DetailView).Add("SelectBoxOptions", dataSources);
            }
            var Details = DetailView.Details as List<dynamic>;

            foreach (var d in Details) {
                var ds = d.DataSourceKey as String;
                if (string.IsNullOrEmpty(ds) != true) {
                    var encryptDs = this.appCrypter.Encrypt(ds);
                    d.DataSourceKey = encryptDs;
                }
            }
            return Ok(DetailView);
        }

        [HttpGet]
        [Route("ListView/{Oid}")]
        public ActionResult GetListViewWithDetails(string Oid)
        {
            bool isDebug = true;
#if DEBUG == false
            isDebug = false;
#endif
            var listView = new DBCollection().GetDynamicObject("EXEC dbo._pGetListViewWithDetails @Oid = \"" + Oid + "\"", !isDebug);
            var StrDataSource = listView.DataSource;
            if (string.IsNullOrEmpty(StrDataSource) != true)
            {
                var encryptDs = this.appCrypter.Encrypt(StrDataSource);
                listView.DataSource = encryptDs;
            }
            var Details = listView.Details as List<dynamic>;
            foreach (var d in Details)
            {
                var ds = d.DataSource as String;
                if (string.IsNullOrEmpty(ds) != true)
                {
                    var encryptDs = this.appCrypter.Encrypt(ds);
                    d.DataSource = ds;
                }
            }
            return Ok(listView);
        }


        [HttpGet]
        [Route("GetListView/{Oid}")]
        public ActionResult GetListView(string Oid)
        {
            var listView = this.ctx.vListView.SingleOrDefault(d => d.Oid.ToString().ToUpper() == Oid.ToUpper());
            if (String.IsNullOrEmpty(listView.DataSource) != true) {
                var encryptDs = this.appCrypter.Encrypt(listView.DataSource);
                listView.DataSource = encryptDs;
            }
            return Ok(listView);
        }
        //
        //
        //
        [HttpPost("ExecuteSP")]
        public ActionResult ExecuteSP(ExecuteParams execParams)
        {

            string SPName = this.appCrypter.Decrypt(execParams.spName);
            if (execParams.isReturnObject == true)
            {
                try
                {
                    var obj = DBCollection._ExecSQLProc(null, SPName, execParams.args, null, true);
                    return Ok(obj);
                }
                catch (Exception ex)
                {

                    return Ok(true);
                }
       
            }
            else {

                DBCollection._ExecSQLProc(null, SPName, execParams.args, null, false);
                return Ok(true);
            }
        }

        [AllowAnonymous]
        [HttpPost("ExecuteSP2")]
        public ActionResult ExecuteSP2(ExecuteParams execParams)
        {
            string SPName = this.appCrypter.Decrypt(execParams.spName);
            execParams.args = this.appCrypter.Decrypt(execParams.args);

            if (execParams.isReturnObject == true)
            {
                try
                {
                    var obj = DBCollection._ExecSQLProc(null, SPName, execParams.args, null, true, execParams.isTransaction);
                    return Ok(obj);
                }
                catch (Exception ex)
                {

                    return Ok(true);
                }

            }
            else
            {

                DBCollection._ExecSQLProc(null, SPName, execParams.args, null, false, execParams.isTransaction);
                return Ok(true);
            }
        }

        [AllowAnonymous]
        [HttpPost("ExecuteSP3")]
        public ActionResult ExecuteSP3(ExecuteParams execParams)
        {
            string SPName = execParams.spName;
            execParams.args = execParams.args;

            if (execParams.isReturnObject == true)
            {
                try
                {
                    var obj = DBCollection._ExecSQLProc(null, SPName, execParams.args, null, true);
                    return Ok(obj);
                }
                catch (Exception ex)
                {

                    return Ok(false);
                }
            }
            else
            {

                DBCollection._ExecSQLProc(null, SPName, execParams.args, null, false);
                return Ok(true);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Query2")]
        public ActionResult Query2(PagingParams p)
        {
            var SQL = p.SQL;
            //var _sql = Utils.Decrypt(SQL);
            var list = Query(SQL);
            return Ok(list);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Query3")]
        public ActionResult Query3(PagingParams p)
        {
            var SQL = this.appCrypter.Decrypt(p.SQL);
            var list = Query(SQL);
            return Ok(list);
        }
    }

    public enum ControlTypeEnum : int {
        TextBox = 1,
        TextArea = 2,
        NumberBox = 3,
        CheckBox = 4,
        DateTimePicker = 5,
        DatePicker = 6,
        TimePicker = 7,
        SelectBox = 8,
        ListBox = 9,
        ColorPicker = 10,
        ListView = 11,
        Tab = 12,
        Section = 13,
        RichTextBox = 14,
        ImageBox = 15,
        FileUploader = 16,
        AutoComplete = 17,
    }

    public class LoadObjectParam { 
        public string Oid_Model { get; set; }
        public string Params { get; set; }
    }

    public class ExecuteParams
    {
        public string args { get; set; }
        public bool isReturnObject { get; set; } = false;
        public bool isTransaction { get; set; } = false;
        public string spName { get; set; }
    }

    public class SavingParams
    {
        public string Oid_Model { get; set; }
        public string Params { get; set; }
    }
} 