using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tAuditTrail
    {
        public tAuditTrail()
        {
            tAuditTrail_Detail = new HashSet<tAuditTrail_Detail>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public Guid? ID_Model { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_User { get; set; }
        public string ID_CurrentObject { get; set; }
        public int? ID_AuditType { get; set; }
        public int? ID_DetailView { get; set; }
        public int? ID_Session { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ID_CreatedBy { get; set; }

        public virtual ICollection<tAuditTrail_Detail> tAuditTrail_Detail { get; set; }
    }
}
