using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vGetViews
    {
        public string name { get; set; }
        public int object_id { get; set; }
        public int? principal_id { get; set; }
        public int schema_id { get; set; }
        public int parent_object_id { get; set; }
        public string type { get; set; }
        public string type_desc { get; set; }
        public DateTime create_date { get; set; }
        public DateTime modify_date { get; set; }
        public bool is_ms_shipped { get; set; }
        public bool is_published { get; set; }
        public bool is_schema_published { get; set; }
        public bool is_auto_executed { get; set; }
        public bool? is_execution_replicated { get; set; }
        public bool? is_repl_serializable_only { get; set; }
        public bool? skips_repl_constraints { get; set; }
    }
}
