using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tNavigation
    {
        public _tNavigation()
        {
            InverseID_ParentNavigation = new HashSet<_tNavigation>();
            tUser_Favorite = new HashSet<tUser_Favorite>();
        }

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

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual _tNavigation ID_ParentNavigation { get; set; }
        public virtual _tView ID_ViewNavigation { get; set; }
        public virtual ICollection<_tNavigation> InverseID_ParentNavigation { get; set; }
        public virtual ICollection<tUser_Favorite> tUser_Favorite { get; set; }
    }
}
