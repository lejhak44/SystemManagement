using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzReceiveDepositCredit
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public string Comment { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public decimal? CreditAmount { get; set; }
        public int? ID_Company { get; set; }
        public string Name_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
