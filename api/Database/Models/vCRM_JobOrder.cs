using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vCRM_JobOrder
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
        public string Project { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Client { get; set; }
    }
}
