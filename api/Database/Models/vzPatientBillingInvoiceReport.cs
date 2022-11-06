using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzPatientBillingInvoiceReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string Name_Patient { get; set; }
        public string BillingAddress { get; set; }
        public string Name_FilingStatus { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string Name_TaxScheme { get; set; }
        public DateTime? DateApproved { get; set; }
        public decimal InitialSubtotalAmount { get; set; }
        public decimal ConfinementDepositAmount { get; set; }
        public decimal ConsumedDepositAmount { get; set; }
        public decimal RemainingDepositAmount { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public int? ID_BillingInvoice_Detail { get; set; }
        public string Name_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? DiscountRate_BillingInvoice_Detail { get; set; }
        public decimal? DiscountAmount_BillingInvoice_Detail { get; set; }
        public decimal? Amount { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Client { get; set; }
        public bool IsWalkIn { get; set; }
        public string WalkInCustomerName { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
        public decimal? TotalItemDiscountAmount { get; set; }
        public string Date_Patient_Confinement_ItemsServices { get; set; }
        public string Code_Patient_Confinement { get; set; }
    }
}
