using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tListView
    {
        public _tListView()
        {
            _tDetailView_DetailID_ListViewNavigation = new HashSet<_tDetailView_Detail>();
            _tDetailView_DetailID_LookUp_ListViewNavigation = new HashSet<_tDetailView_Detail>();
            _tListView_Detail = new HashSet<_tListView_Detail>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public Guid? ID_Model { get; set; }
        public string DataSource { get; set; }
        public string Comment { get; set; }
        public string Caption { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? PageSize { get; set; }
        public bool? IsAllowAdd { get; set; }
        public bool? IsAllowDelete { get; set; }
        public bool? IsAllowEdit { get; set; }
        public string JsController { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual _tModel ID_ModelNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> _tDetailView_DetailID_ListViewNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> _tDetailView_DetailID_LookUp_ListViewNavigation { get; set; }
        public virtual ICollection<_tListView_Detail> _tListView_Detail { get; set; }
    }
}
