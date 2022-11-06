using JSLibrary;
using Microsoft.AspNetCore.Mvc;
using ngJSApp.Database;
using ngJSApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ngJSApp.Controllers
{
    public partial class ModelController
    {
        
        [HttpGet("GetNavigations")]
        public ActionResult GetNavigations() {
            var SessionUser = this.HttpContext.User;
            string ID_User = SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_User").Value;
            string ID_Session = SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_Session").Value;
            List<__vNavigation> list = null;

            if (ID_User == "1")
            {
                list = ctx.__vNavigation.Where(s => s.IsActive == true).ToList();
            }
            else {
                var allowedModules = new DBCollection().GetDynamicCollections("SELECT * FROM [dbo].fGetUserModules(" + ID_User + ") WHERE ID_Navigation IS NOT NULL");
                var OidNavigations = allowedModules.Select(s => s.ID_Navigation.ToString().ToUpper()).ToList();
                list = ctx.__vNavigation.Where(s => (s.ID_View == null || OidNavigations.Contains(s.Oid.ToString().ToUpper())) && s.IsActive == true).ToList();
            }
            return Ok(list);
        }

        [HttpGet("GetModuleRights/{ID_View}")]
        public ActionResult GetModuleRights(string ID_View) {
            var SessionUser = this.HttpContext.User;
            string ID_User = SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_User").Value;
            var Models = new DBCollection().GetDynamicCollections("SELECT TOP 1 ID_Model FROM _vModuleViews WHERE Oid = '" + ID_View + "'").ToArray();
            if (Models == null) return NotFound("Module not found");
            string ID_Model = Models[0].ID_Model + "";
            string ID_Session = SessionUser.Claims.SingleOrDefault(d => d.Type == "ID_Session").Value;  
            var allowedModules = new DBCollection().GetDynamicCollections("SELECT TOP 1 * FROM [dbo].fGetUserModules(" + ID_User + ") WHERE ID_Model = '" + ID_Model + "'");
            if (allowedModules == null) return NotFound("Module not found");
            if (allowedModules[0].IsView != 1 ) return NotFound("Module not allowed for User " + ID_User);
            return Ok(allowedModules[0]);
        }


    }
   
} 