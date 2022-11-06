using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vSMSList_Patient_Vaccination_Schedule
    {
        public int ID { get; set; }
        public int? ID_Patient_Vaccination { get; set; }
        public string Code { get; set; }
        public DateTime? DateSent { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string ContactNumber { get; set; }
        public string Message { get; set; }
        public DateTime? DateSending { get; set; }
        public int? ID_Company { get; set; }
        public bool IsSentSMS { get; set; }
        public Guid Oid_Model { get; set; }
    }
}
