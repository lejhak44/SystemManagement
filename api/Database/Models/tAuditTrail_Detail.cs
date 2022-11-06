using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tAuditTrail_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public Guid? ID_Model { get; set; }
        public int? ID_AuditTrail { get; set; }
        public string ID_CurrentObject { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ModelProperty { get; set; }
        public int? ID_AuditTrailType { get; set; }

        public virtual tAuditTrail ID_AuditTrailNavigation { get; set; }
    }
}
