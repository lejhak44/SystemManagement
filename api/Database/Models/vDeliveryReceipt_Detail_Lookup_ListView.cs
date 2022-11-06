﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vDeliveryReceipt_Detail_Lookup_ListView
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
        public int? ID_DeliveryReceipt { get; set; }
        public int? ID_Doc { get; set; }
        public int? ID_DocDetail { get; set; }
        public decimal? SOQuantity { get; set; }
        public string DocReference { get; set; }
        public Guid? ID_DocModel { get; set; }
        public string Item { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string UOM { get; set; }
        public string DocStatus { get; set; }
        public string DocumentNo { get; set; }
    }
}
