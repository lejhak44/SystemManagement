using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Wellness_Detail_Listview
    {
        public int ID { get; set; }
        public int? ID_Patient_Wellness { get; set; }
        public string Name_Item { get; set; }
        public DateTime? Date { get; set; }
        public string Comment { get; set; }
        public int? ID_Patient_SOAP { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
    }
}
