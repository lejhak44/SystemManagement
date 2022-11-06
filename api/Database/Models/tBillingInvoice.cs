using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tBillingInvoice
    {
        public tBillingInvoice()
        {
            tBillingInvoice_Detail = new HashSet<tBillingInvoice_Detail>();
            tBillingInvoice_Patient = new HashSet<tBillingInvoice_Patient>();
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

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice_Detail> tBillingInvoice_Detail { get; set; }
        public virtual ICollection<tBillingInvoice_Patient> tBillingInvoice_Patient { get; set; }
    }
}
