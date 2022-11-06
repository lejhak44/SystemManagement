using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tDetailView_Detail
    {
        public _tDetailView_Detail()
        {
            InverseID_SectionNavigation = new HashSet<_tDetailView_Detail>();
            InverseID_TabNavigation = new HashSet<_tDetailView_Detail>();
            _tDetailView_Detail_LinkID_DetailView_DetailNavigation = new HashSet<_tDetailView_Detail_Link>();
            _tDetailView_Detail_LinkID_DetailView_Detail_LinkNavigation = new HashSet<_tDetailView_Detail_Link>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? SeqNo { get; set; }
        public string Comment { get; set; }
        public string Caption { get; set; }
        public Guid? ID_ModelProperty { get; set; }
        public Guid ID_DetailView { get; set; }
        public Guid? ID_Tab { get; set; }
        public Guid? ID_Section { get; set; }
        public int? ID_ControlType { get; set; }
        public int? ID_PropertyType { get; set; }
        public string Format { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string DisplayProperty { get; set; }
        public string DataSource { get; set; }
        public bool? IsLoadData { get; set; }
        public int? ColCount { get; set; }
        public int? ColSpan { get; set; }
        public bool? IsDisabled { get; set; }
        public int? Height { get; set; }
        public Guid? ID_ListView { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? ID_LabelLocation { get; set; }
        public bool? IsShowLabel { get; set; }
        public bool? IsRequired { get; set; }
        public string ValueExpr { get; set; }
        public string DisplayExpr { get; set; }
        public Guid? ID_LookUp_ListView { get; set; }
        public string LookUp_ListView_Caption { get; set; }
        public string LookUp_ListView_DataSource { get; set; }
        public int? GroupIndex { get; set; }
        public string SearchExpr { get; set; }
        public int? Precision { get; set; }
        public Guid? ID_Parent_Grid { get; set; }
        public bool? IsShowClearButton { get; set; }
        public bool? IsSearchEnabled { get; set; }
        public string InputMask { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual _tDetailView ID_DetailViewNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual _tListView ID_ListViewNavigation { get; set; }
        public virtual _tListView ID_LookUp_ListViewNavigation { get; set; }
        public virtual _tModel_Property ID_ModelPropertyNavigation { get; set; }
        public virtual _tDetailView_Detail ID_SectionNavigation { get; set; }
        public virtual _tDetailView_Detail ID_TabNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> InverseID_SectionNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> InverseID_TabNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail_Link> _tDetailView_Detail_LinkID_DetailView_DetailNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail_Link> _tDetailView_Detail_LinkID_DetailView_Detail_LinkNavigation { get; set; }
    }
}
