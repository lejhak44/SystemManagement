using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPaymentTransaction
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

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
