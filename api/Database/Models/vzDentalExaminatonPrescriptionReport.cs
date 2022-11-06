using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzDentalExaminatonPrescriptionReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name_Patient { get; set; }
        public string Name_Doctor { get; set; }
        public DateTime? Date { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Comment { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
    }
}
