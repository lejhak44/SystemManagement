using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSalesInvoice_Collections
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
        public int? ID_Doc { get; set; }
        public decimal? SIAmount { get; set; }
        public decimal? Payable { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ID_Collection { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
