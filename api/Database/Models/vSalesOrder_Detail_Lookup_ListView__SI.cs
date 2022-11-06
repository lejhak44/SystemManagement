using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSalesOrder_Detail_Lookup_ListView__SI
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ID_UOM { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int VATRate { get; set; }
        public int VATAmount { get; set; }
        public int Subtotal { get; set; }
        public decimal? DiscountAMount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ID_DocDetail { get; set; }
        public int ID_Doc { get; set; }
        public string DocumentNo { get; set; }
        public string DocReference { get; set; }
        public string Item { get; set; }
        public int ID_SalesOrder { get; set; }
    }
}
