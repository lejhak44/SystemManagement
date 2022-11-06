using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSentSMSRecord
    {
        public string Code { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateSchedule { get; set; }
        public DateTime? DateSending { get; set; }
        public int? ID_Company { get; set; }
    }
}
