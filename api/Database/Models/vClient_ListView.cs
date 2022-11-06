using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vClient_ListView
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ContactNumbers { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLastVisited { get; set; }
        public bool IsActive { get; set; }
    }
}
