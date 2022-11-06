﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPatient_Wellness_Detail
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
        public int? ID_Patient_Wellness { get; set; }
        public int? ID_Item { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? DateExpiration { get; set; }
        public int? tPatient_Vaccination_Detail { get; set; }
        public int? ID_Patient_Vaccination_Detail { get; set; }
        public int? Quantity { get; set; }
        public string CustomItem { get; set; }
        public int? Appointment_ID_FilingStatus { get; set; }
        public string Appointment_CancellationRemarks { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tPatient_Wellness ID_Patient_WellnessNavigation { get; set; }
    }
}
