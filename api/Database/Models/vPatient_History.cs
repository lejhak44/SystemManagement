using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_History
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_Patient { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_Doctor { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string DateString { get; set; }
        public string Name_Doctor { get; set; }
        public string Name_FilingStatus { get; set; }
    }
}
