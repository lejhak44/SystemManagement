using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUser_Favorite
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_User { get; set; }
        public Guid ID_Navigation { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ID_CreatedBy { get; set; }

        public virtual _tNavigation ID_NavigationNavigation { get; set; }
        public virtual tUser ID_UserNavigation { get; set; }
    }
}
