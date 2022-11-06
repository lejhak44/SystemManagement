using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPayable_PayableDetail_Listview
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_Company { get; set; }
        public string Name_ExpenseCategory { get; set; }
        public string Name_Payable_Detail { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Payment_ID_FilingStatus { get; set; }
        public string Payment_Name_FilingStatus { get; set; }
        public decimal? RemaningAmount { get; set; }
        public decimal? PaidAmount { get; set; }
    }
}
