using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPurchaseOrder_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_PurchaseOrder { get; set; }
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public int? ID_UOM { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Balance { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public int? RemainingQuantity { get; set; }
        public int? ID_PurchaseOrder_Detail { get; set; }
        public string Item { get; set; }
        public string UOM { get; set; }
        public string Name_Item { get; set; }
        public string Name_UOM { get; set; }
    }
}
