using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPaymentTransaction
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
        public int? ID_TaxScheme { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_PaymentMethod { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CheckAmount { get; set; }
        public string CheckNumber { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ChangeAmount { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_CanceledBy { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? GCashAmount { get; set; }
        public int? ID_CardType { get; set; }
        public string CardHolderName { get; set; }
        public string ReferenceTransactionNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal? RemainingAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string DateString { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string CanceledBy_Name_User { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Name_TaxScheme { get; set; }
        public decimal? GrossAmount_BillingInvoice { get; set; }
        public decimal? VatAmount_BillingInvoice { get; set; }
        public decimal? NetAmount_BillingInvoice { get; set; }
        public decimal? RemainingAmount_BillingInvoice { get; set; }
        public string Name_PaymentMethod { get; set; }
        public string Name_CardType { get; set; }
        public string DateCreatedString { get; set; }
        public string DateModifiedString { get; set; }
        public string DateApprovedString { get; set; }
        public string DateCanceledString { get; set; }
    }
}
