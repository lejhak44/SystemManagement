using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Lodging_Listview
    {
        public int ID { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public decimal? HourCount { get; set; }
        public decimal? PayableAmount { get; set; }
        public string Name_FilingStatus { get; set; }
        public int? ID_Company { get; set; }
    }
}
