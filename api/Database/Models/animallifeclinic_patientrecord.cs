using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class animallifeclinic_patientrecord
    {
        public double? CaseID { get; set; }
        public string Date { get; set; }
        public string Patient { get; set; }
        public string Chief_Complaint { get; set; }
        public string FollowupDate__SOAP_Plan_ { get; set; }
        public string Treatment { get; set; }
        public string Complete { get; set; }
        public string Prescription { get; set; }
        public string Attending_Vet { get; set; }
        public double? PatientID { get; set; }
    }
}
