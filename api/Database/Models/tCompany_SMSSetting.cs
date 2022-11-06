using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCompany_SMSSetting
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public int? MaxSMSCountPerDay { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
    }
}
