using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCRM_Status
    {
        public tCRM_Status()
        {
            tCRM_IssueTracker = new HashSet<tCRM_IssueTracker>();
            tCRM_JobOrder = new HashSet<tCRM_JobOrder>();
            tCRM_JobOrder_Detail = new HashSet<tCRM_JobOrder_Detail>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<tCRM_IssueTracker> tCRM_IssueTracker { get; set; }
        public virtual ICollection<tCRM_JobOrder> tCRM_JobOrder { get; set; }
        public virtual ICollection<tCRM_JobOrder_Detail> tCRM_JobOrder_Detail { get; set; }
    }
}
