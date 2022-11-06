using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCRM_JobOrder
    {
        public tCRM_JobOrder()
        {
            tCRM_JobOrder_Comment = new HashSet<tCRM_JobOrder_Comment>();
            tCRM_JobOrder_Detail = new HashSet<tCRM_JobOrder_Detail>();
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
        public int? ID_CRM_Project { get; set; }
        public int? ID_CRM_IssueTracker { get; set; }
        public int? ID_CRM_Status { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public int? ID_FilingStatus { get; set; }

        public virtual tBusinessPartner ID_BusinessPartnerNavigation { get; set; }
        public virtual tCRM_IssueTracker ID_CRM_IssueTrackerNavigation { get; set; }
        public virtual tCRM_Project ID_CRM_ProjectNavigation { get; set; }
        public virtual tCRM_Status ID_CRM_StatusNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCRM_JobOrder_Comment> tCRM_JobOrder_Comment { get; set; }
        public virtual ICollection<tCRM_JobOrder_Detail> tCRM_JobOrder_Detail { get; set; }
    }
}
