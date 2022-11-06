using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItemInventoriableForBillingLookUp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public string FormattedCurrentInventoryCount { get; set; }
        public int CurrentInventoryCount { get; set; }
        public int? ID_Company { get; set; }
        public string RemainingBeforeExpired { get; set; }
        public int? RemainingDays { get; set; }
        public DateTime? OtherInfo_DateExpiration { get; set; }
    }
}
