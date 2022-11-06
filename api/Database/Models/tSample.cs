using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tSample
    {
        public int? ID_Company { get; set; }
        public string Name_Company { get; set; }
        public string Name_Client { get; set; }
        public string ContactNumber_Client { get; set; }
        public DateTime? DateReturn { get; set; }
        public string Name_Item { get; set; }
        public string Comment { get; set; }
        public string Message { get; set; }
        public DateTime? DateSending { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ID_Reference { get; set; }
        public string Oid_Model { get; set; }
        public string Code { get; set; }
    }
}
