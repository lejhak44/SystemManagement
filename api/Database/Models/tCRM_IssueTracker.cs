using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCRM_IssueTracker
    {
        public tCRM_IssueTracker()
        {
            tCRM_JobOrder = new HashSet<tCRM_JobOrder>();
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
        public int ID_BusinessPartner { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_CRM_Status { get; set; }

        public virtual tBusinessPartner ID_BusinessPartnerNavigation { get; set; }
        public virtual tCRM_Status ID_CRM_StatusNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCRM_JobOrder> tCRM_JobOrder { get; set; }
    }
}
