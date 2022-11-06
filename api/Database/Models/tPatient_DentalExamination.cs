using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient_DentalExamination
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_Patient { get; set; }
        public int? ID_Doctor { get; set; }
        public DateTime? Date { get; set; }
        public string GUID { get; set; }
        public int? ID_Dentition { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public int? ID_CanceledBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCanceled { get; set; }

        public virtual tPatient ID_PatientNavigation { get; set; }
    }
}
