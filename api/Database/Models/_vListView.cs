using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vListView
    {
        public string _DataSource { get; set; }
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
        public string Model { get; set; }
        public string PrimaryKey { get; set; }
    }
}
