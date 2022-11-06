using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tWarehouse
    {
        public tWarehouse()
        {
            InverseID_WarehouseNavigation = new HashSet<tWarehouse>();
            tUserSession = new HashSet<tUserSession>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_Warehouse { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tWarehouse ID_WarehouseNavigation { get; set; }
        public virtual ICollection<tWarehouse> InverseID_WarehouseNavigation { get; set; }
        public virtual ICollection<tUserSession> tUserSession { get; set; }
    }
}
