using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tMessageRoom_User_Message
    {
        public int ID { get; set; }
        public int? ID_ChatRoom { get; set; }
        public int? ID_User { get; set; }
        public int? Message { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? IsRead { get; set; }
    }
}
