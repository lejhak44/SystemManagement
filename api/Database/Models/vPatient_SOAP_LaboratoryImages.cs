using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_SOAP_LaboratoryImages
    {
        public int ID_Patient_SOAP { get; set; }
        public string ImageRowIndex { get; set; }
        public long? RowIndex { get; set; }
        public string ImageNo { get; set; }
        public string FilePath { get; set; }
        public string Remark { get; set; }
    }
}
