using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tDetailView_Detail_Link
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

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual _tDetailView_Detail ID_DetailView_DetailNavigation { get; set; }
        public virtual _tDetailView_Detail ID_DetailView_Detail_LinkNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
