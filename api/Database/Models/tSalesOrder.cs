﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSalesOrder
    {
        public tSalesOrder()
        {
            tSalesOrder_Detail = new HashSet<tSalesOrder_Detail>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_BusinessPartner { get; set; }
        public int? ID_Warehouse { get; set; }
        public int? ID_TaxScheme { get; set; }
        public decimal? VATRate { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_DocStatus { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public int? ID_CancelledBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCancelled { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Address { get; set; }
        public int? ID_SalesOrderType { get; set; }
        public int? ID_BusinessPartnerContact { get; set; }
        public decimal? TotalDiscount { get; set; }
        public DateTime? PODate { get; set; }
        public string PONumber { get; set; }
        public int? ID_AccountExecutive { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public int? ID_PaymentTerm { get; set; }
        public string CancellationReason { get; set; }

        public virtual tBusinessPartner ID_BusinessPartnerNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tFilingStatus ID_FilingStatusNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tWarehouse ID_WarehouseNavigation { get; set; }
        public virtual ICollection<tSalesOrder_Detail> tSalesOrder_Detail { get; set; }
    }
}
