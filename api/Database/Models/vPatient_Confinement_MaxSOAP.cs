using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_Confinement_MaxSOAP
    {
        public int ID_Patient_SOAP { get; set; }
        public DateTime? MaxDate { get; set; }
        public int? ID_Patient_Confinement { get; set; }
        public int? ID_FilingStatus { get; set; }
    }
}
