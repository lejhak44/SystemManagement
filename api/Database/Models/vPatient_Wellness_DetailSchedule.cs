using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Wellness_DetailSchedule
    {
        public int ID_Patient_Wellness { get; set; }
        public string Code { get; set; }
        public int ID_Patient_Wellness_Detail { get; set; }
        public int ID_Patient_Wellness_Schedule { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Item_Patient_Wellness_Detail { get; set; }
        public DateTime? DateCreated_Patient_Wellness_Detail { get; set; }
        public string Comment_Patient_Wellness_Detail { get; set; }
        public DateTime? Date_Patient_Wellness_Schedule { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? IsSentSMS { get; set; }
        public int? Appointment_ID_FilingStatus { get; set; }
        public string Appointment_Name_FilingStatus { get; set; }
        public string Appointment_CancellationRemarks { get; set; }
    }
}
