using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUserSession
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_User { get; set; }
        public int? ID_Warehouse { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual tUser ID_UserNavigation { get; set; }
        public virtual tWarehouse ID_WarehouseNavigation { get; set; }
    }
}
