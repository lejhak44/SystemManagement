using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vGenerateTSClass
    {
        public string TS { get; set; }
        public string Name { get; set; }
        public byte system_type_id { get; set; }
        public int column_id { get; set; }
        public string TableName { get; set; }
    }
}
