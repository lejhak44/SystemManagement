using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSalesInvoice_Lookup_ListView
    {
        public int ID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Name { get; set; }
        public string ReferenceNo { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? Subtotal { get; set; }
        public int? ID_BusinessPartner { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string BusinessPartner { get; set; }
        public int SIBalance { get; set; }
        public string FilingStatus { get; set; }
    }
}
