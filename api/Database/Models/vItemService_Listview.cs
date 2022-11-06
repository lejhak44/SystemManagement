using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItemService_Listview
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ID_Company { get; set; }
        public decimal UnitPrice { get; set; }
        public bool? IsActive { get; set; }
    }
}
