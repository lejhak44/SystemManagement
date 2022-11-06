using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vRemainingQuantityPurchaseOrderDetail
    {
        public int ID { get; set; }
        public string Name_Item { get; set; }
        public int? Quantity { get; set; }
        public int? RemainingQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? ID_PurchaseOrder { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string Name_FilingStatus { get; set; }
        public string ServingStatus_Name_FilingStatus { get; set; }
    }
}
