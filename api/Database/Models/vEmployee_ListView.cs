using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vEmployee_ListView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Name_Position { get; set; }
        public int? ID_Company { get; set; }
        public string ContactNumber { get; set; }
        public string FullAddress { get; set; }
    }
}
