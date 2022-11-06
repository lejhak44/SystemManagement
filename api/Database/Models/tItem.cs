using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tItem
    {
        public tItem()
        {
            tItem_Supplier = new HashSet<tItem_Supplier>();
            tPurchaseOrder_Detail = new HashSet<tPurchaseOrder_Detail>();
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
        public int? ID_ItemType { get; set; }
        public int? ID_ItemCategory { get; set; }
        public int? MinInventoryCount { get; set; }
        public int? MaxInventoryCount { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CurrentInventoryCount { get; set; }
        public int? Old_item_id { get; set; }
        public int? Old_procedure_id { get; set; }
        public DateTime? OtherInfo_DateExpiration { get; set; }
        public int? ID_InventoryStatus { get; set; }
        public string BarCode { get; set; }
        public string CustomCode { get; set; }
        public string _tempSupplier { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tItemCategory ID_ItemCategoryNavigation { get; set; }
        public virtual tItemType ID_ItemTypeNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItem_Supplier> tItem_Supplier { get; set; }
        public virtual ICollection<tPurchaseOrder_Detail> tPurchaseOrder_Detail { get; set; }
    }
}
