using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tInventoryAdjustment_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int ID_InventoryAdjustment { get; set; }
        public int? ID_Item { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tInventoryAdjustment ID_InventoryAdjustmentNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
