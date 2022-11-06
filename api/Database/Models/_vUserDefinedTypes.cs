using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vUserDefinedTypes
    {
        public string Type { get; set; }
        public int user_type_id { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public byte TypeID { get; set; }
        public int ColumnId { get; set; }
    }
}
