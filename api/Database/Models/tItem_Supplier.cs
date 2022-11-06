using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tItem_Supplier
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_Item { get; set; }
        public int? ID_Supplier { get; set; }

        public virtual tItem ID_ItemNavigation { get; set; }
    }
}
