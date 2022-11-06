using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vBillingInvoice_Detail
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
        public int? ID_BillingInvoice { get; set; }
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? DateExpiration { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsComputeDiscountRate { get; set; }
        public decimal? DiscountRate { get; set; }
        public int? ID_Patient_Confinement_ItemsServices { get; set; }
        public int? ID_Patient_Vaccination { get; set; }
        public int? ID_Patient_Wellness_Detail { get; set; }
        public string Name_Item { get; set; }
    }
}
