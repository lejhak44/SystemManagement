using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tInventoryHistory
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public Guid ID_DocModel { get; set; }
        public int ID_Doc { get; set; }
        public int ID_DocDetail { get; set; }
        public int ID_Item { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public int ID_UOM { get; set; }
        public int UnitCost { get; set; }
        public int? ID_BusinessPartner { get; set; }
        public string Reference { get; set; }
    }
}
