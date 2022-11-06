using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tItemIssuance_Detail
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
        public int? ID_Item { get; set; }
        public int? ID_UOM { get; set; }
        public int? ID_DocStatus { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? VATRate { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ID_ItemIssuance { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tItemIssuance ID_ItemIssuanceNavigation { get; set; }
        public virtual tItem ID_ItemNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
