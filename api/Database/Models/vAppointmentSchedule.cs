using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vAppointmentSchedule
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
        public int? ID_Schedule { get; set; }
        public int? ID_ScheduleType { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? ID_Doctor { get; set; }
        public int? ID_Patient { get; set; }
        public int? ID_ServiceType { get; set; }
        public int? AppointmentStatus_ID_FilingStatus { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string ScheduleType { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public string Name_ServiceType { get; set; }
        public string AppointmentStatus_Name_FilingStatus { get; set; }
    }
}
