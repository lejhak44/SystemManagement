using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCRM_JobOrder_Detail
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
        public int ID_CRM_JobOrder { get; set; }
        public int? ID_CRM_Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ID_AssignedTo { get; set; }
        public DateTime? DateAssigned { get; set; }
        public string Detail { get; set; }
        public DateTime? LastHoldDate { get; set; }
        public DateTime? LastResumeDate { get; set; }
        public int? ID_ResumeBy { get; set; }
        public int? ID_HoldBy { get; set; }
        public int? ID_StartedBy { get; set; }
        public int? ID_CheckedBy { get; set; }
        public DateTime? CheckedDate { get; set; }

        public virtual tEmployee ID_AssignedToNavigation { get; set; }
        public virtual tCRM_JobOrder ID_CRM_JobOrderNavigation { get; set; }
        public virtual tCRM_Status ID_CRM_StatusNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
