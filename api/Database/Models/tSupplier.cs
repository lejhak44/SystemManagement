﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSupplier
    {
        public tSupplier()
        {
            tPurchaseOrder = new HashSet<tPurchaseOrder>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string Address { get; set; }
        public string ContactDetail { get; set; }
        public string TINNumber { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPurchaseOrder> tPurchaseOrder { get; set; }
    }
}
