using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tTicketing_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_Ticketing { get; set; }

        public virtual tTicketing ID_TicketingNavigation { get; set; }
    }
}
