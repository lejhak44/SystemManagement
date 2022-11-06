using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient_Confinement
    {
        public tPatient_Confinement()
        {
            tPatient_Confinement_ItemsServices = new HashSet<tPatient_Confinement_ItemsServices>();
            tPatient_Confinement_Patient = new HashSet<tPatient_Confinement_Patient>();
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
        public DateTime? Date { get; set; }
        public DateTime? DateDischarge { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_DischargeBy { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_CanceledBy { get; set; }
        public int? BillingInvoice_ID_FilingStatus { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public string PatientNames { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement_ItemsServices> tPatient_Confinement_ItemsServices { get; set; }
        public virtual ICollection<tPatient_Confinement_Patient> tPatient_Confinement_Patient { get; set; }
    }
}
