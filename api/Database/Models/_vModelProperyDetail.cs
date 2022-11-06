using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vModelProperyDetail
    {
        public string Name { get; set; }
        public string FieldKey { get; set; }
        public string TableName { get; set; }
        public string PrimaryKey { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAggregated { get; set; }
    }
}
