using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzClientDepositReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy_Name_User { get; set; }
        public string Name_FilingStatus { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public decimal? DepositAmount { get; set; }
        public string FormattedDepositAmount { get; set; }
        public string Code_Patient_Confinement { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
