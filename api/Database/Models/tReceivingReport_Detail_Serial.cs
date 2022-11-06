using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tReceivingReport_Detail_Serial
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_ReceivingReport_Detail { get; set; }

        public virtual tReceivingReport_Detail ID_ReceivingReport_DetailNavigation { get; set; }
    }
}
