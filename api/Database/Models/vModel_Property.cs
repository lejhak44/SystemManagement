using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vModel_Property
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Caption { get; set; }
        public Guid ID_Model { get; set; }
        public int? ID_PropertyType { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? ID_PropertyModel { get; set; }
        public Guid? ID_ModelProperty_Key { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsAggregated { get; set; }
        public string DisplayProperty { get; set; }
    }
}
