using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUser_Roles
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_User { get; set; }
        public int? ID_UserRole { get; set; }
        public int? SeqNo { get; set; }

        public virtual tUser ID_UserNavigation { get; set; }
        public virtual tUserRole ID_UserRoleNavigation { get; set; }
    }
}
