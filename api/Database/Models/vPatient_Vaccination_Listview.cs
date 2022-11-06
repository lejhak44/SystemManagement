using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Vaccination_Listview
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public int? ID_Patient { get; set; }
        public string Name_Patient { get; set; }
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string Name_FilingStatus { get; set; }
        public DateTime? DateExpiration { get; set; }
        public string Comment { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_Patient_SOAP { get; set; }
    }
}
