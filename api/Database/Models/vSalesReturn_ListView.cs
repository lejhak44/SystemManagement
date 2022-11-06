using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSalesReturn_ListView
    {
        public int ID { get; set; }
        public int? ID_SalesReturn { get; set; }
        public int? ID_BillingInvoice { get; set; }
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
    }
}
