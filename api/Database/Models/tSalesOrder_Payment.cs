﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSalesOrder_Payment
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
        public int ID_SalesOrder { get; set; }
        public int ID_SalesInvoice { get; set; }
        public decimal? SOTotalAmount { get; set; }
        public decimal? SITotalAmount { get; set; }
        public int ID_FilingStatus { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
