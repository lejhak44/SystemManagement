using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vBillingInvoice
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
        public int? ID_Patient { get; set; }
        public int? ID_TaxScheme { get; set; }
        public DateTime? Date { get; set; }
        public string BillingAddress { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatPercentage { get; set; }
        public decimal? NetAmount { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public int? ID_CanceledBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? Payment_ID_FilingStatus { get; set; }
        public decimal? RemainingAmount { get; set; }
        public int? ID_Client { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountRate { get; set; }
        public bool? IsComputeDiscountRate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? AttendingPhysician_ID_Employee { get; set; }
        public int? ID_SOAPType { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public int? ID_Patient_Confinement { get; set; }
        public string PatientNames { get; set; }
        public decimal? ConfinementDepositAmount { get; set; }
        public decimal? RemainingDepositAmount { get; set; }
        public decimal? ConsumedDepositAmount { get; set; }
        public decimal? InitialSubtotalAmount { get; set; }
        public int? ID_Patient_Vaccination { get; set; }
        public bool? IsWalkIn { get; set; }
        public string WalkInCustomerName { get; set; }
        public int? ID_Patient_Wellness { get; set; }
        public decimal? TotalItemDiscountAmount { get; set; }
        public string DateString { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public string LastModifiedBy_Name_User { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string CanceledBy_Name_User { get; set; }
        public string Company { get; set; }
        public string Name_Patient { get; set; }
        public string Name_TaxScheme { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Payment_Name_FilingStatus { get; set; }
        public string Name_Client { get; set; }
        public string DateCreatedString { get; set; }
        public string DateModifiedString { get; set; }
        public string DateApprovedString { get; set; }
        public string DateCanceledString { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
        public string Status { get; set; }
        public string Name_SOAPType { get; set; }
    }
}
