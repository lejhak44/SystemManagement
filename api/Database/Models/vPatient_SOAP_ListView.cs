using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_SOAP_ListView
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_SOAPType { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public string Name_SOAPType { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Name_FilingStatus { get; set; }
        public int? ID_Patient_Confinement { get; set; }
        public string History { get; set; }
        public string ClinicalExamination { get; set; }
        public string Interpretation { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string ClientCommunication { get; set; }
        public string Prescription { get; set; }
        public int? Count_History { get; set; }
        public int? Count_ClinicalExamination { get; set; }
        public int? Count_LaboratoryImages { get; set; }
        public int? Count_Diagnosis { get; set; }
        public int? Count_Treatment { get; set; }
        public int? Count_ClientCommunication { get; set; }
        public int Count_Plan { get; set; }
        public int? Count_Prescription { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string TooltipText { get; set; }
    }
}
