using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient
    {
        public tPatient()
        {
            tPatient_DentalExamination = new HashSet<tPatient_DentalExamination>();
            tPatient_History = new HashSet<tPatient_History>();
            tPatient_SOAP_RegularConsoltation = new HashSet<tPatient_SOAP_RegularConsoltation>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int? ID_Gender { get; set; }
        public string Email { get; set; }
        public DateTime? DateBirth { get; set; }
        public string FullAddress { get; set; }
        public int? ID_Country { get; set; }
        public string ContactNumber { get; set; }
        public int? ID_Company { get; set; }
        public string Species { get; set; }
        public int? ID_Client { get; set; }
        public bool? IsNeutered { get; set; }
        public bool? IsDeceased { get; set; }
        public int? Old_patient_id { get; set; }
        public string AnimalWellness { get; set; }
        public DateTime? DateDeceased { get; set; }
        public DateTime? DateLastVisited { get; set; }
        public decimal? CurrentCreditAmount { get; set; }
        public string ProfileImageFile { get; set; }
        public string CustomCode { get; set; }
        public int? WaitingStatus_ID_FilingStatus { get; set; }
        public string Microchip { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination> tPatient_DentalExamination { get; set; }
        public virtual ICollection<tPatient_History> tPatient_History { get; set; }
        public virtual ICollection<tPatient_SOAP_RegularConsoltation> tPatient_SOAP_RegularConsoltation { get; set; }
    }
}
