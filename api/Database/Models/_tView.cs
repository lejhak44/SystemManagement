using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tView
    {
        public _tView()
        {
            _tNavigation = new HashSet<_tNavigation>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public Guid? ID_ListView { get; set; }
        public Guid? ID_Report { get; set; }
        public Guid? ID_Dashboard { get; set; }
        public int? ID_ViewType { get; set; }
        public string CustomViewPath { get; set; }
        public string ControllerPath { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? ID_Model { get; set; }
        public string DataSource { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual _tModel ID_ModelNavigation { get; set; }
        public virtual ICollection<_tNavigation> _tNavigation { get; set; }
    }
}
