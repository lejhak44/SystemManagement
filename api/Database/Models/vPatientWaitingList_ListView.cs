using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatientWaitingList_ListView
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
        public int? WaitingStatus_ID_FilingStatus { get; set; }
        public int? BillingInvoice_ID_FilingStatus { get; set; }
        public string WaitingStatus_Name_FilingStatus { get; set; }
        public string BillingInvoice_Name_FilingStatus { get; set; }
    }
}
