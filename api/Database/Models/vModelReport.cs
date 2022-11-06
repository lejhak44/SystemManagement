using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vModelReport
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Company { get; set; }
        public string Oid_Model { get; set; }
        public string Name_Model { get; set; }
        public string Oid_Report { get; set; }
        public string Name_Report { get; set; }
        public string Name_ModelReport { get; set; }
    }
}
