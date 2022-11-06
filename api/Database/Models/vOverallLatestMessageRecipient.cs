using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vOverallLatestMessageRecipient
    {
        public int? Sender_ID_User { get; set; }
        public string Sender_Name_User { get; set; }
        public int? Recipient_ID_User { get; set; }
        public string Recipient_Name_User { get; set; }
        public int? TotalReadCount { get; set; }
        public DateTime? LastDateSent { get; set; }
        public bool? IsRead { get; set; }
    }
}
