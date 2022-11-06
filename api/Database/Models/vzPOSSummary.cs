using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzPOSSummary
    {
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public int? Quantity { get; set; }
        public int? ID_BillingInvoice { get; set; }
        public DateTime? Date { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ID_ItemType { get; set; }
        public string Name_ItemType { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
