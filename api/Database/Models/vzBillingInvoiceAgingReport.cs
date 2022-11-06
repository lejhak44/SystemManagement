using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzBillingInvoiceAgingReport
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Date_BillingInvoice { get; set; }
        public string Code { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string Status { get; set; }
        public string Age { get; set; }
        public int? AgeDays { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
