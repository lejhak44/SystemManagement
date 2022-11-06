using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient_Confinement_ItemsServices
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
        public int? ID_Patient_Confinement { get; set; }
        public int? ID_Item { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateExpiration { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Amount { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public int? ID_Patient_SOAP_Treatment { get; set; }
        public int? ID_Patient_SOAP_Prescription { get; set; }
        public string Route { get; set; }
        public int? ID_Patient { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tPatient_Confinement ID_Patient_ConfinementNavigation { get; set; }
    }
}
