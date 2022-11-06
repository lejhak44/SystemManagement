using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vReceivingReport_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_ReceivingReport { get; set; }
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public string Name_Item { get; set; }
        public int? ID_PurchaseOrder_Detail { get; set; }
    }
}
