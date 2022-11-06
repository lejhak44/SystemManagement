using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPurchaseOrder_Listview
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public int? ID_Company { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy_Name_User { get; set; }
        public DateTime? DateModified { get; set; }
        public string LastModifiedBy_Name_User { get; set; }
        public DateTime? DateApproved { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string CanceledBy_Name_User { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string Name_FilingStatus { get; set; }
        public string ServingStatus_Name_FilingStatus { get; set; }
        public string DateString { get; set; }
        public string DateCreatedString { get; set; }
        public string DateModifiedString { get; set; }
        public string DateApprovedString { get; set; }
        public string DateCanceledString { get; set; }
        public string Name_Supplier { get; set; }
    }
}
