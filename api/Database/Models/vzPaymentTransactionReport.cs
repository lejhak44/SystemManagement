using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzPaymentTransactionReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string Code_BillingInvoice { get; set; }
        public string BillingAddress { get; set; }
        public string Name_Patient { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Name_PaymentMethod { get; set; }
        public string CheckNumber { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ChangeAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string PaymentAmountString { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Client { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
    }
}
