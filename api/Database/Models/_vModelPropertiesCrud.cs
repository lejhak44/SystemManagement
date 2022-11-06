using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vModelPropertiesCrud
    {
        public string Name { get; set; }
        public Guid ID_Model { get; set; }
        public int? ID_PropertyType { get; set; }
        public string TableName { get; set; }
        public Guid? ID_PropertyModel { get; set; }
        public string PropertyModel { get; set; }
        public string PropertyModel_TableName { get; set; }
        public string PropertyModel_PrimaryKey { get; set; }
        public string PropertyModel_Link { get; set; }
        public int? PropertyModel_Type { get; set; }
    }
}
