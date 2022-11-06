using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_DentalExamination_ToothInfo
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
        public int? ID_Patient_DentalExamination { get; set; }
        public int? ID_Tooth { get; set; }
        public string IDs_ToothSurface { get; set; }
        public int? ID_ToothStatus { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public int? ToothNumber_Tooth { get; set; }
        public string Location_Tooth { get; set; }
        public string Name_ToothStatus { get; set; }
        public string Code_ToothStatus { get; set; }
    }
}
