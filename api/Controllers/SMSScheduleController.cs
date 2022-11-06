using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ngJSApp.Database;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using ngJSApp.Database.Models;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using ngJSApp.HubConfig;
using Microsoft.AspNetCore.SignalR;
using JSLibrary;
using System.Dynamic;

namespace ngJSApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SMSScheduleController : Controller
    {
        private IConfiguration _config;
        AppDbContext ctx = null;
        IAppCrypterService crypter = null;

        private readonly IHubContext<ChatHub> _chathubContext;
        public SMSScheduleController(
            IConfiguration config,
            AppDbContext _ctx,
            IHubContext<ChatHub> chathubContext,
            IAppCrypterService _crypter)
        {
            _config = config;
            this.ctx = _ctx;
            this.crypter = _crypter;

            _chathubContext = chathubContext;
        }

        [AllowAnonymous]
        [Route("PendingOneDayBeforeAppointment")]
        [HttpPost]
        public ActionResult PendingOneDayBeforeAppointment()
        {
            var dbAccess = new DBCollection();
            var sql = "EXEC dbo.pGetForSendSOAPPlan_OneDayBeforeAppointment";
            var result = dbAccess.GetDynamicObject(sql, true);

            return Ok(new
            {
                result.Records
            });
        }

        [AllowAnonymous]
        [Route("PendingYesterdayAppointment")]
        [HttpPost]
        public ActionResult PendingYesterdayAppointment()
        {
            var dbAccess = new DBCollection();
            var sql = "EXEC dbo.pGetForSendSOAPPlan_YesterdayAppointment";
            var result = dbAccess.GetDynamicObject(sql, true);

            return Ok(new
            {
                result.Records
            });
        }

        [AllowAnonymous]
        [Route("UpdateSMSScheduleStatus")]
        [HttpPost]
        public ActionResult UpdateSMSScheduleStatus(string UniqueID, int iTextMo_Status)
        {
            dynamic result; 

            try
            {
                string[] splittedString = UniqueID.Split("##");
                string database = splittedString[0];
                string Oid = splittedString[1];
                string ID_Reference = splittedString[2];
                var dbAccess = new DBCollection();

                var sql = "EXEC dbo.pNoteSOAPPlanAsSend /*ID_Reference*/, '/*Oid_Model*/', /*iTextMo_Status*/";
                sql = sql.Replace("/*ID_Reference*/", ID_Reference);
                sql = sql.Replace("/*Oid_Model*/", Oid);
                sql = sql.Replace("/*iTextMo_Status*/", iTextMo_Status.ToString());

                dbAccess.sqlConn.Open();
                dbAccess.sqlConn.ChangeDatabase(database);

                result = dbAccess.GetDynamicObject(sql, true);

            }
            catch (Exception ex)
            {
                dynamic _result;
                _result = new ExpandoObject();
                _result.Success = false;

                result =(dynamic) _result;
            }

            return Ok(new
            {
                result
            });
        }
    }
}
