using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzPaymentTransactionSummaryReport
    {
        public int ID_BillingInvoice { get; set; }
        public int ID_PaymentTransaction { get; set; }
        public string Code_BillingInvoice { get; set; }
        public DateTime? Date_BillingInvoice { get; set; }
        public decimal? BalanceAmount { get; set; }
        public string Code_PaymentTransaction { get; set; }
        public DateTime? Date_PaymentTransaction { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_PaymentMethod { get; set; }
        public string Name_PaymentMethod { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
        public int AttendingPhysician_ID_Employee { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
        public string Name_Position { get; set; }
    }
}
