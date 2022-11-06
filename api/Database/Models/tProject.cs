using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tProject
    {
        public tProject()
        {
            tProject_Detail = new HashSet<tProject_Detail>();
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
        public int? ID_BusinessPartner { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tProject_Detail> tProject_Detail { get; set; }
    }
}
