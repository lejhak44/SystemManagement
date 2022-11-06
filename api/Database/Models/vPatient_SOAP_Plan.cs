using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_SOAP_Plan
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public DateTime? DateReturn { get; set; }
        public int? ID_Item { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? IsSentSMS { get; set; }
        public string CustomItem { get; set; }
        public int? old_return_patient_id { get; set; }
        public int? Appointment_ID_FilingStatus { get; set; }
        public string Appointment_CancellationRemarks { get; set; }
        public string Name_Item { get; set; }
        public string Appointment_Name_FilingStatus { get; set; }
    }
}
