using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vForBilling_ListView
    {
        public int ID { get; set; }
        public string RefNo { get; set; }
        public int ID_CurrentObject { get; set; }
        public Guid Oid_Model { get; set; }
        public DateTime? Date { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public int? BillingInvoice_ID_FilingStatus { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string BillingInvoice_Name_FilingStatus { get; set; }
        public string _1 { get; set; }
        public string _2 { get; set; }
        public string _3 { get; set; }
        public string _4 { get; set; }
        public string _5 { get; set; }
        public string _6 { get; set; }
        public string _7 { get; set; }
        public string _8 { get; set; }
        public string _9 { get; set; }
        public string _10 { get; set; }
    }
}
