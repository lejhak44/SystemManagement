using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vAppointmentEvent
    {
        public string ID { get; set; }
        public string UniqueID { get; set; }
        public Guid Oid_Model { get; set; }
        public string Name_Model { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_Client { get; set; }
        public int ID_CurrentObject { get; set; }
        public int Appointment_ID_CurrentObject { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string FormattedDateStart { get; set; }
        public string FormattedDateEnd { get; set; }
        public string FormattedDateStartTime { get; set; }
        public string FormattedDateEndTime { get; set; }
        public string ReferenceCode { get; set; }
        public string Paticular { get; set; }
        public string Description { get; set; }
        public string TimeCoverage { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Name_Client { get; set; }
        public int? ID_Patient { get; set; }
        public string Name_Patient { get; set; }
        public string ContactNumber { get; set; }
        public int? Appointment_ID_FilingStatus { get; set; }
        public string Appointment_Name_FilingStatus { get; set; }
        public string Appointment_CancellationRemarks { get; set; }
    }
}
