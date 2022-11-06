using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Vaccination_Schedule
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
        public int? ID_Patient_Vaccination { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? IsSentSMS { get; set; }
        public string CustomItem { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
