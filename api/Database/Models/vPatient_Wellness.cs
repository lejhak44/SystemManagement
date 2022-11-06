﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Wellness
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
        public DateTime? Date { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public int? AttendingPhysician_ID_Employee { get; set; }
        public string AttendingPhysician { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? DateCanceled { get; set; }
        public int? ID_CanceledBy { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public int? ID_Patient_Vaccination { get; set; }
        public int? old_schedule_id { get; set; }
        public int? old_appointment_id { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Name_FilingStatus { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
    }
}
