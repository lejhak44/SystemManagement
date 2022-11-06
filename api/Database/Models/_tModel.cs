using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tModel
    {
        public _tModel()
        {
            _tDetailView = new HashSet<_tDetailView>();
            _tListView = new HashSet<_tListView>();
            _tModel_PropertyID_ModelNavigation = new HashSet<_tModel_Property>();
            _tModel_PropertyID_PropertyModelNavigation = new HashSet<_tModel_Property>();
            _tView = new HashSet<_tView>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public string TableName { get; set; }
        public string DisplayName { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? ID_DetailView { get; set; }
        public string Caption { get; set; }
        public string ViewSource { get; set; }
        public string ControllerPath { get; set; }
        public string Icon { get; set; }
        public bool? IsLoadData { get; set; }
        public bool? IsEnableAuditTrail { get; set; }
        public bool? IsEnableComment { get; set; }
        public bool? IsEnableFileAttachment { get; set; }
        public bool? IsSearchEnabled { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual _tDetailView ID_DetailViewNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tDetailView> _tDetailView { get; set; }
        public virtual ICollection<_tListView> _tListView { get; set; }
        public virtual ICollection<_tModel_Property> _tModel_PropertyID_ModelNavigation { get; set; }
        public virtual ICollection<_tModel_Property> _tModel_PropertyID_PropertyModelNavigation { get; set; }
        public virtual ICollection<_tView> _tView { get; set; }
    }
}
