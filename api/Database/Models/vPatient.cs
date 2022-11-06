using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient
    {
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
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string FullName { get; set; }
        public string Name_Gender { get; set; }
        public string PhoneCode_Country { get; set; }
        public string Name_Client { get; set; }
        public bool? IsActive_Client { get; set; }
        public string ProfileImageLocationFile { get; set; }
        public string ProfileImageThumbnailLocationFile { get; set; }
        public string WaitingStatus_Name_FilingStatus { get; set; }
    }
}
