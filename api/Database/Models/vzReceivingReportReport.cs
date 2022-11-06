using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzReceivingReportReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Code_PurchaseOrder { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_Supplier { get; set; }
        public string Name_Supplier { get; set; }
        public string Name_FilingStatus { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string Name_TaxScheme { get; set; }
        public DateTime? DateApproved { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public int? ID_ReceivingReport_Detail { get; set; }
        public string Name_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
    }
}
