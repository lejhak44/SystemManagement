using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vModel
    {
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
        public string PrimaryKey { get; set; }
        public string DetailView { get; set; }
    }
}
