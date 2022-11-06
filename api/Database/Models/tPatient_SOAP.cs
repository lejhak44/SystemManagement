using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient_SOAP
    {
        public tPatient_SOAP()
        {
            tPatient_SOAP_Plan = new HashSet<tPatient_SOAP_Plan>();
            tPatient_SOAP_Prescription = new HashSet<tPatient_SOAP_Prescription>();
            tPatient_SOAP_Treatment = new HashSet<tPatient_SOAP_Treatment>();
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
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Prescription { get; set; }
        public string Planning { get; set; }
        public int? ID_Patient { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_SOAPType { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public int? ID_CanceledBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? Old_soap_id { get; set; }
        public string LabImageFilePath01 { get; set; }
        public string LabImageFilePath02 { get; set; }
        public string LabImageFilePath03 { get; set; }
        public string LabImageFilePath04 { get; set; }
        public string LabImageFilePath05 { get; set; }
        public string LabImageFilePath06 { get; set; }
        public string LabImageFilePath07 { get; set; }
        public string LabImageFilePath08 { get; set; }
        public string LabImageFilePath09 { get; set; }
        public string LabImageFilePath10 { get; set; }
        public string LabImageFilePath11 { get; set; }
        public string LabImageFilePath12 { get; set; }
        public string LabImageFilePath13 { get; set; }
        public string LabImageFilePath14 { get; set; }
        public string LabImageFilePath15 { get; set; }
        public string LabImageRemark01 { get; set; }
        public string LabImageRemark02 { get; set; }
        public string LabImageRemark03 { get; set; }
        public string LabImageRemark04 { get; set; }
        public string LabImageRemark05 { get; set; }
        public string LabImageRemark06 { get; set; }
        public string LabImageRemark07 { get; set; }
        public string LabImageRemark08 { get; set; }
        public string LabImageRemark09 { get; set; }
        public string LabImageRemark10 { get; set; }
        public string LabImageRemark11 { get; set; }
        public string LabImageRemark12 { get; set; }
        public string LabImageRemark13 { get; set; }
        public string LabImageRemark14 { get; set; }
        public string LabImageRemark15 { get; set; }
        public string LabImageRowIndex01 { get; set; }
        public string LabImageRowIndex02 { get; set; }
        public string LabImageRowIndex03 { get; set; }
        public string LabImageRowIndex04 { get; set; }
        public string LabImageRowIndex05 { get; set; }
        public string LabImageRowIndex06 { get; set; }
        public string LabImageRowIndex07 { get; set; }
        public string LabImageRowIndex08 { get; set; }
        public string LabImageRowIndex09 { get; set; }
        public string LabImageRowIndex10 { get; set; }
        public string LabImageRowIndex11 { get; set; }
        public string LabImageRowIndex12 { get; set; }
        public string LabImageRowIndex13 { get; set; }
        public string LabImageRowIndex14 { get; set; }
        public string LabImageRowIndex15 { get; set; }
        public string History { get; set; }
        public int? AttendingPhysician_ID_Employee { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string ClientCommunication { get; set; }
        public string ClinicalExamination { get; set; }
        public string Interpretation { get; set; }
        public DateTime? DateDone { get; set; }
        public int? ID_DoneBy { get; set; }
        public int? ID_Patient_Confinement { get; set; }
        public string CaseType { get; set; }
        public int? BillingInvoice_ID_FilingStatus { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_Plan> tPatient_SOAP_Plan { get; set; }
        public virtual ICollection<tPatient_SOAP_Prescription> tPatient_SOAP_Prescription { get; set; }
        public virtual ICollection<tPatient_SOAP_Treatment> tPatient_SOAP_Treatment { get; set; }
    }
}
