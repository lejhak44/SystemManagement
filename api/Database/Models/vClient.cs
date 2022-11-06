using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vClient
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
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber2 { get; set; }
        public int? Old_client_id { get; set; }
        public string tempID { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? DateLastVisited { get; set; }
        public decimal? CurrentCreditAmount { get; set; }
    }
}
