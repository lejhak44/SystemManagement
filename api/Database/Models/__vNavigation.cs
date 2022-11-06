using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class __vNavigation
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? ID_Parent { get; set; }
        public Guid? ID_View { get; set; }
        public string View { get; set; }
        public string Text { get; set; }
        public string icon { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_ViewType { get; set; }
        public Guid? ID_Model { get; set; }
        public Guid? ID_ListView { get; set; }
        public Guid? ID_Report { get; set; }
        public string Model { get; set; }
        public int SeqNo { get; set; }
        public string Route { get; set; }
    }
}
