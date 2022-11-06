using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSMSCountPerCompany
    {
        public DateTime? DateSchedule { get; set; }
        public int? ID_Company { get; set; }
        public int? TotalSMSCount { get; set; }
    }
}
