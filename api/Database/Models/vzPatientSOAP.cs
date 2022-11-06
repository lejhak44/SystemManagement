using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzPatientSOAP
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public DateTime? Date { get; set; }
        public string Comment { get; set; }
        public string Name_CreatedBy { get; set; }
        public string Name_Gender { get; set; }
        public string Species { get; set; }
        public string Age_Patient { get; set; }
        public string History { get; set; }
        public string ClinicalExamination { get; set; }
        public string LaboratoryRemarks { get; set; }
        public string Planning { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public string ClientCommunication { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public int? ID_Company { get; set; }
        public string Name_FilingStatus { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
        public string AttendingPhysician_PRCLicenseNumber_Employee { get; set; }
        public string AttendingPhysician_PTR_Employee { get; set; }
        public string AttendingPhysician_TINNumber_Employee { get; set; }
        public string AttendingPhysician_S2_Employee { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
    }
}
