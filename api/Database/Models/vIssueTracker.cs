using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vIssueTracker
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string Issue { get; set; }
        public string DeveloperSide { get; set; }
        public string Solution { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? ID_ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Name_ApprovedBy { get; set; }
    }
}
