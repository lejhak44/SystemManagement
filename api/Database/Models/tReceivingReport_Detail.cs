using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tReceivingReport_Detail
    {
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
        public int? ID_ReceivingReport { get; set; }
        public int? ID_PurchaseOrder_Detail { get; set; }
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tReceivingReport ID_ReceivingReportNavigation { get; set; }
    }
}
