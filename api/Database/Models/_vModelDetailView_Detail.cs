using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vModelDetailView_Detail
    {
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
        public string DetailView { get; set; }
    }
}
