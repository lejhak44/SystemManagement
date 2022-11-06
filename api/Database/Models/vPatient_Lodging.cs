using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Lodging
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
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? ID_FilingStatus { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public decimal? RateAmount { get; set; }
        public decimal? AdvancedPaymentAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? HourCount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? ChangeAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Name_FilingStatus { get; set; }
    }
}
