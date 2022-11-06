using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vMessage
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_User { get; set; }
        public int? Sender_ID_User { get; set; }
        public bool? IsOpened { get; set; }
        public int? Recipient_ID_User { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Recipient_Name_User { get; set; }
    }
}
