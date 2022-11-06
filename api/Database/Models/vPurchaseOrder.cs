using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPurchaseOrder
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
        public int? ID_Supplier { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TotalVAT { get; set; }
        public decimal? TotalGrossAmount { get; set; }
        public decimal? TotalNetAmount { get; set; }
        public decimal? TotalVatAmount { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_SubmittedBy { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int? ID_TaxScheme { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public DateTime? DateCancelled { get; set; }
        public int? ID_CancelledBy { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_CanceledBy { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ServingStatus_ID_FilingStatus { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsComputeDiscountRate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public string LastModifiedBy_Name_User { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string CanceledBy_Name_User { get; set; }
        public string Name_FilingStatus { get; set; }
        public string ServingStatus_Name_FilingStatus { get; set; }
        public string Name_TaxScheme { get; set; }
        public string Name_Supplier { get; set; }
        public string DateString { get; set; }
        public string DateCreatedString { get; set; }
        public string DateModifiedString { get; set; }
        public string DateApprovedString { get; set; }
        public string DateCanceledString { get; set; }
    }
}
