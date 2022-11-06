using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tMessageRoom_User
    {
        public int ID { get; set; }
        public int? ID_ChatRoom { get; set; }
        public int? ID_User { get; set; }
    }
}
