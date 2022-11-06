using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vVeterinaryHealthCertificate_ListView
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public int? ID_Patient { get; set; }
        public string Name_Patient { get; set; }
        public int? AttendingPhysician_ID_Employee { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string Name_FilingStatus { get; set; }
        public string DestinationAddress { get; set; }
        public int? ID_Company { get; set; }
    }
}
