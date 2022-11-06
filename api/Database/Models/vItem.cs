using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItem
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
        public int? ID_ItemType { get; set; }
        public int? ID_ItemCategory { get; set; }
        public int? MinInventoryCount { get; set; }
        public int? MaxInventoryCount { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CurrentInventoryCount { get; set; }
        public int? Old_item_id { get; set; }
        public int? Old_procedure_id { get; set; }
        public DateTime? OtherInfo_DateExpiration { get; set; }
        public int? ID_InventoryStatus { get; set; }
        public string BarCode { get; set; }
        public string CustomCode { get; set; }
        public string _tempSupplier { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public string LastModifiedBy_Name_User { get; set; }
        public string Name_ItemType { get; set; }
        public string Name_ItemCategory { get; set; }
        public string Name_InventoryStatus { get; set; }
        public int? _CurrentInventoryCount { get; set; }
    }
}
