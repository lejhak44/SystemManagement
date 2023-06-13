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
    public class ConfigController : Controller
    {
        private IConfiguration _config;
        AppDbContext ctx = null;
        IAppCrypterService crypter = null;

        private readonly IHubContext<ChatHub> _chathubContext;
        public ConfigController(
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
        [Route("GetEmailConfig")]
        [HttpPost]
        public ActionResult GetEmailConfig()
        {

            dynamic config;

            using (StreamReader streamReader = new StreamReader(@$"App_Data/Config/EmailConfig.json"))
            {
                string content = streamReader.ReadToEnd();
                config = content;
            }

            return Ok(new
            {
                config
            });
        }
    }
}
