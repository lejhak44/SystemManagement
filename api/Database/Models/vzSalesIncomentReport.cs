using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzSalesIncomentReport
    {
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public DateTime? Date_BillingInvoice { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? GrossSales { get; set; }
        public decimal? NetCost { get; set; }
        public int AttendingPhysician_ID_Employee { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
    }
}
