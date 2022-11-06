using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vsample
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string UnitCost { get; set; }
        public int? ID_ItemType { get; set; }
    }
}
