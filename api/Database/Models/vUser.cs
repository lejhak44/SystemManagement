using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vUser
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_Employee { get; set; }
        public string Username { get; set; }
        public int ID_UserGroup { get; set; }
        public string Password { get; set; }
        public bool? IsRequiredPasswordChangedOnLogin { get; set; }
        public int? ID_Patient { get; set; }
        public string Employee { get; set; }
        public string Name_Employee { get; set; }
        public string UserGroup { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Company { get; set; }
        public string Code_Company { get; set; }
        public int? ID_Position { get; set; }
    }
}
