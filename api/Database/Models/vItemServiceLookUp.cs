using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vItemServiceLookUp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public int? ID_Company { get; set; }
    }
}
