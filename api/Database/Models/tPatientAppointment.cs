﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatientAppointment
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
        public int? ID_Patient { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? ID_Doctor { get; set; }
        public int? ID_ScheduleType { get; set; }
        public int? AppointmentStatus_ID_FilingStatus { get; set; }
        public int? ID_SOAPType { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? DateDone { get; set; }
        public int? ID_DoneBy { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_CanceledBy { get; set; }
        public int? Appointment_ID_FilingStatus { get; set; }
        public string Appointment_CancellationRemarks { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
