using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Confinement_Listview
    {
        public int ID { get; set; }
        public string Name_Client { get; set; }
        public string Name_Patient { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string ConfinementDays { get; set; }
        public int? ConfinementDayCount { get; set; }
        public int? ID_Company { get; set; }
        public int? ID_FilingStatus { get; set; }
        public int? BillingInvoice_ID_FilingStatus { get; set; }
        public DateTime? DateDischarge { get; set; }
        public string Name_FilingStatus { get; set; }
        public string BillingInvoice_Name_FilingStatus { get; set; }
        public int? ID_Client { get; set; }
        public int? ID_Patient { get; set; }
    }
}
