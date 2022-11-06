using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vInventory
    {
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public int? Quantity { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_InventoryStatus { get; set; }
        public string Name_InventoryStatus { get; set; }
        public string colorStatus { get; set; }
    }
}
