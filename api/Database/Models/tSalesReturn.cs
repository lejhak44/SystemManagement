using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSalesReturn
    {
        public tSalesReturn()
        {
            tSalesReturn_Detail = new HashSet<tSalesReturn_Detail>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_BillingInvoice { get; set; }
        public DateTime? Date { get; set; }
        public bool? TotalAmount { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_CanceledBy { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSalesReturn_Detail> tSalesReturn_Detail { get; set; }
    }
}
