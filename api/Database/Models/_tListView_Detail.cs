using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tListView_Detail
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public string Caption { get; set; }
        public Guid? ID_ModelProperty { get; set; }
        public Guid? ID_ListView { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string DisplayProperty { get; set; }
        public string DataSource { get; set; }
        public string Format { get; set; }
        public string Width { get; set; }
        public bool? Fixed { get; set; }
        public int? VisibleIndex { get; set; }
        public bool? IsAllowEdit { get; set; }
        public int? ID_ControlType { get; set; }
        public int? ID_ColumnAlignment { get; set; }
        public bool? IsVisible { get; set; }
        public string FixedPosition { get; set; }
        public bool? IsRequired { get; set; }
        public int? ID_SummaryType { get; set; }
        public int? Precision { get; set; }
        public int? ID_PropertyType { get; set; }
        public bool? IsAddModelClass { get; set; }
        public int? GroupIndex { get; set; }
        public bool? IsFilter { get; set; }
        public int? ID_FilterControlType { get; set; }

        public virtual _tColumnAlignment ID_ColumnAlignmentNavigation { get; set; }
        public virtual _tControlType ID_ControlTypeNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual _tListView ID_ListViewNavigation { get; set; }
    }
}
