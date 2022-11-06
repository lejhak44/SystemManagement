using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPayable
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
        public DateTime? Date { get; set; }
        public int? Payment_ID_FilingStatus { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? RemaningAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Payment_Name_FilingStatus { get; set; }
    }
}
