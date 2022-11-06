using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSMSCountPerCompany_Patient_Vaccination_Schedule
    {
        public DateTime? DateSent { get; set; }
        public int? ID_Company { get; set; }
        public int? TotalSMSCount { get; set; }
    }
}
