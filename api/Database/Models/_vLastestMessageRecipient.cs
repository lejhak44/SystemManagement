using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _vLastestMessageRecipient
    {
        public int? Sender_ID_User { get; set; }
        public int? Recipient_ID_User { get; set; }
        public string Recipient_Name_User { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? LastDateSent { get; set; }
    }
}
