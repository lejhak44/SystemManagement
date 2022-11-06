using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSchedule
    {
        public tSchedule()
        {
            tSchedule_PatientAppointment = new HashSet<tSchedule_PatientAppointment>();
        }

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
        public int? ID_ScheduleType { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? AccommodateCount { get; set; }
        public int? Count { get; set; }
        public int? ID_Doctor { get; set; }
        public int? VacantCount { get; set; }
        public int? ID_ServiceType { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSchedule_PatientAppointment> tSchedule_PatientAppointment { get; set; }
    }
}
