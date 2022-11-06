using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItemInventoriableLookUp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public string UnitCost { get; set; }
        public string FormattedCurrentInventoryCount { get; set; }
        public int CurrentInventoryCount { get; set; }
        public int? ID_Company { get; set; }
    }
}
