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

namespace ngJSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        AppDbContext ctx = null;
        IAppCrypterService crypter = null;

        private readonly IHubContext<ChatHub> _chathubContext;
        public LoginController(
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
        [Route("Token")]
        [HttpPost]
        public ActionResult Login(LoginFormData data)
        {

            var dbAccess = new DBCollection();
            var _password = String.IsNullOrWhiteSpace(data.Password) != true ? crypter.Decrypt(data.Password) : "";

            var sql = "EXEC dbo.pDoUserLogin '/*Username*/', '/*Password*/'";
            sql = sql.Replace("/*Username*/", data.Username);
            sql = sql.Replace("/*Password*/", _password);
           

            var result = dbAccess.GetDynamicObject(sql, true);
            dynamic CurrentUser;

            if (result.Success != true)
            {
                return NotFound(result.message);
            }

            CurrentUser = result.CurrentUser[0];

            var jwt = new JwtService(_config, this.crypter);
            var Token = jwt.GenerateSecurityToken(CurrentUser, data.Password);
            var EncryptToken = jwt.GenerateEncryptedToken(CurrentUser, data.Password);
            return Ok(new
            {
                Token,
                EncryptToken,
                CurrentUser.ID,
                CurrentUser.ID_Employee,
                CurrentUser.FirstName,
                CurrentUser.LastName,
                CurrentUser.ID_Company,
                ID_UserSession = CurrentUser.ID_UserSession
            });
        }

        [AllowAnonymous]
        [Route("OneDayBeforeAppointment")]
        [HttpPost]
        public ActionResult OneDayBeforeAppointment()
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
        [Route("InitReceptionPortal")]
        [HttpPost]
        public ActionResult LoginReceptionPortal(LoginReceptionPortalData data)
        {
            LoginFormData loginData = new LoginFormData();

            var sql = $"SELECT TOP 1 Username, Password FROM vUser WHERE Username = '{data.CompanyCode}-receptionportal' AND ReceptionPortalGuid = '{data.ReceptionPortalGuid}'";

            var user = new DBCollection().GetDynamicCollections(sql).ToArray();

            loginData.Username = user[0].Username;
            loginData.Password = crypter.Encrypt(user[0].Password);

            return this.Login(loginData);
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult LoginClient(LoginFormData data)
        {
            return this.Login(data);
        }

        [AllowAnonymous]
        [Route("LoginAPI")]
        [HttpPost]
        public ActionResult LoginAPI(LoginFormData data)
        {
            
            return Ok(data);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("CheckSession")]
        public ActionResult CheckSession()
        {


            var SessionUser = this.HttpContext.User;
            int ID_Session =  Int32.Parse(SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_Session").Value);
            var CurrentSession = this.ctx.tUserSession.Where(s=>s.IsActive == true).SingleOrDefault(d => d.ID == ID_Session);
            if (CurrentSession == null) {
                return Ok(new
                {
                    ID = -1,
                    ID_Warehouse = -1,
                    IsValid = false
                });
            }
            return Ok(new { 
                CurrentSession.ID,
                CurrentSession.ID_Warehouse,
                IsValid = true
            });
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("CheckSessionByPost")]
        public ActionResult CheckSessionByPost()
        {
            var SessionUser = this.HttpContext.User;
            int ID_Session = Int32.Parse(SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_Session").Value);
            var CurrentSession = this.ctx.tUserSession.Where(s => s.IsActive == true).SingleOrDefault(d => d.ID == ID_Session);
            if (CurrentSession == null)
            {
                return Ok(new
                {
                    ID = -1,
                    ID_Warehouse = -1,
                    IsValid = false
                });
            }
            return Ok(new
            {
                CurrentSession.ID,
                CurrentSession.ID_Warehouse,
                IsValid = true
            });
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Logout/{ID_Session}")]
        public ActionResult Logout(int ID_Session)
        {
            var CurrentSession = this.ctx.tUserSession.Where(s=>s.IsActive == true).SingleOrDefault(d => d.ID == ID_Session);
            if (CurrentSession == null)
            {
                return NotFound("Current Session not exsisting");
            }
            CurrentSession.IsActive = false;
            ctx.Entry(CurrentSession).State = EntityState.Modified;
            ctx.SaveChanges();
            return Ok(new
            {
                CurrentSession.ID,
                CurrentSession.ID_Warehouse,
                IsValid = true
            });
        }


        [AllowAnonymous]
        [Route("ClientToken")]
        [HttpPost]
        public ActionResult ClientLogin(LoginFormData data)
        {

            var dbAccess = new DBCollection();
            var _password = String.IsNullOrWhiteSpace(data.Password) != true ? crypter.Decrypt(data.Password) : "";

            var sql = "EXEC dbo.pDoClientLogin '/*Username*/', '/*Password*/'";
            sql = sql.Replace("/*Username*/", data.Username);
            sql = sql.Replace("/*Password*/", _password);


            var result = dbAccess.GetDynamicObject(sql, true);
            dynamic CurrentUser;

            if (result.Success != true)
            {
                return NotFound(result.message);
            }

            CurrentUser = result.CurrentUser[0];

            var jwt = new UniversalJwtService(_config, this.crypter);
            var Token = jwt.GenerateSecurityToken(CurrentUser, data.Password);
            var EncryptToken = jwt.GenerateEncryptedToken(CurrentUser, data.Password);
            return Ok(new
            {
                Token,
                EncryptToken,
                CurrentUser.ID,
                CurrentUser.ID_User_Reference,
                CurrentUser.ID_Model_Reference,
                //CurrentUser.ID_Client,
                CurrentUser.Name,
                CurrentUser.ID_Company,
                ID_UserSession = CurrentUser.ID_UserSession
            });
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ClientCheckSession")]
        public ActionResult ClientCheckSession()
        {


            var SessionUser = this.HttpContext.User;
            int ID_Session = Int32.Parse(SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_Session").Value);
            var CurrentSession = this.ctx.tUserSession.Where(s => s.IsActive == true).SingleOrDefault(d => d.ID == ID_Session);
            if (CurrentSession == null)
            {
                return Ok(new
                {
                    ID = -1,
                    ID_Warehouse = -1,
                    IsValid = false
                });
            }
            return Ok(new
            {
                CurrentSession.ID,
                CurrentSession.ID_Warehouse,
                IsValid = true
            });
        }

        [CustomAuthorize]
        [HttpGet]
        [Route("ClientLogout/{ID_Session}")]
        public ActionResult ClientLogout(int ID_Session)
        {
            var CurrentSession = this.ctx.tUserSession.Where(s => s.IsActive == true).SingleOrDefault(d => d.ID == ID_Session);
            if (CurrentSession == null)
            {
                return NotFound("Current Session not exsisting");
            }
            CurrentSession.IsActive = false;
            ctx.Entry(CurrentSession).State = EntityState.Modified;
            ctx.SaveChanges();
            return Ok(new
            {
                CurrentSession.ID,
                CurrentSession.ID_Warehouse,
                IsValid = true
            });
        }


    }


    public class LoginFormData {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginReceptionPortalData
    {
        public string CompanyCode { get; set; }
        public string ReceptionPortalGuid { get; set; }
    }

}