using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzInventorySummaryReport
    {
        public int ID { get; set; }
        public string Name_Item { get; set; }
        public int? TotalQuantity { get; set; }
        public int? DateExpired { get; set; }
        public int? BatchNo { get; set; }
        public DateTime? DateLastIn { get; set; }
        public DateTime? DateLastOut { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string RemainingBeforeExpired { get; set; }
        public int? RemainingDays { get; set; }
        public string Name_InventoryStatus { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
