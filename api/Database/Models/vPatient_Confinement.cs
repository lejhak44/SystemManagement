using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Confinement
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
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Name_FilingStatus { get; set; }
        public string BillingInvoice_Name_FilingStatus { get; set; }
    }
}
