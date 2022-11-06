using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vNavigation
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? ID_View { get; set; }
        public string Caption { get; set; }
        public string Icon { get; set; }
        public int? SeqNo { get; set; }
        public Guid? ID_Parent { get; set; }
        public string Route { get; set; }
        public int? ID_ViewType { get; set; }
    }
}
