using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItemInventoriable_ListvIew
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RemainingBeforeExpired { get; set; }
        public int? RemainingDays { get; set; }
        public DateTime? DateExpired { get; set; }
        public int? ID_Company { get; set; }
        public int? CurrentInventoryCount { get; set; }
        public int? ID_InventoryStatus { get; set; }
        public string Name_InventoryStatus { get; set; }
        public bool? IsActive { get; set; }
    }
}
