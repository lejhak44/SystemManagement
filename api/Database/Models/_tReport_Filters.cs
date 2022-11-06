using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tReport_Filters
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public Guid? ID_Report { get; set; }
        public int? ID_ControlType { get; set; }
        public int? ID_PropertyType { get; set; }
        public string DataSource { get; set; }
        public string Caption { get; set; }
    }
}
