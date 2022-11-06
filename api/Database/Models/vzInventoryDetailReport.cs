using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzInventoryDetailReport
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
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateExpired { get; set; }
        public int? BatchNo { get; set; }
        public string Name_Item { get; set; }
        public string Name_FilingStatus { get; set; }
        public string DateString { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string Name_InventoryStatus { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
