using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUserRole
    {
        public tUserRole()
        {
            tUserRole_Detail = new HashSet<tUserRole_Detail>();
            tUserRole_Reports = new HashSet<tUserRole_Reports>();
            tUser_Roles = new HashSet<tUser_Roles>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string Description { get; set; }
        public bool? IsFullAccess { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUserRole_Detail> tUserRole_Detail { get; set; }
        public virtual ICollection<tUserRole_Reports> tUserRole_Reports { get; set; }
        public virtual ICollection<tUser_Roles> tUser_Roles { get; set; }
    }
}
