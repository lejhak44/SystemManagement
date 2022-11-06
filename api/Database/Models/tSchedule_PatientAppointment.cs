using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSchedule_PatientAppointment
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_Schedule { get; set; }
        public int? ID_ScheduleType { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? ID_Doctor { get; set; }
        public int? ID_Patient { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual tSchedule ID_ScheduleNavigation { get; set; }
    }
}
