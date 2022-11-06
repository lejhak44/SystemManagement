using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tMessageThread
    {
        public int ID { get; set; }
        public int? Recipient_ID_User { get; set; }
        public int? Sender_ID_User { get; set; }
        public string Message { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateRead { get; set; }
        public bool? IsRead { get; set; }
    }
}
