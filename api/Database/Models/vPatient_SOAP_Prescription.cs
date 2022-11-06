using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_SOAP_Prescription
    {
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
        public int? ID_Item { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
        public DateTime? DateExpiration { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? IsCharged { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Name_Item { get; set; }
    }
}
