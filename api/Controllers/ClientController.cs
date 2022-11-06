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
    public class ClientController : Controller
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
        public ActionResult ClientMobileNumberByCompany(string Oid_Company)
        {
            var dbAccess = new DBCollection();
            var sql = "EXEC dbo.pGetClientMobileNumberByCompany '/*Oid_Company*/'";
            sql = sql.Replace("/*Oid_Company*/", Oid_Company);

            var result = dbAccess.GetDynamicObject(sql, true);

            return Ok(new
            {
                result.Records
            });
        }
    }
}
