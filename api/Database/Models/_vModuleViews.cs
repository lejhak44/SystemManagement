using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vModuleViews
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? ID_Model { get; set; }
        public int ViewType { get; set; }
    }
}
