using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUserRole_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_UserRole { get; set; }
        public string ID_Model { get; set; }
        public bool? IsView { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsDeny { get; set; }
        public int? SeqNo { get; set; }

        public virtual tUserRole ID_UserRoleNavigation { get; set; }
    }
}
