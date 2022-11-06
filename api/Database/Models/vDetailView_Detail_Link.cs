using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vDetailView_Detail_Link
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
        public Guid ID_DetailView_Detail { get; set; }
        public Guid? ID_DetailView_Detail_Link { get; set; }
        public bool? IsRequired { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
