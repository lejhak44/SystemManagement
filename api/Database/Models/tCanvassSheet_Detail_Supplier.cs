using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCanvassSheet_Detail_Supplier
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_CanvassSheet_Detail { get; set; }
        public int? ID_BusinessPartner { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual tCanvassSheet_Detail ID_CanvassSheet_DetailNavigation { get; set; }
    }
}
