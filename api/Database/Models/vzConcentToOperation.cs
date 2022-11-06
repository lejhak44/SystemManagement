using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzConcentToOperation
    {
        public int ID { get; set; }
        public string Name_Patient { get; set; }
        public string Name_Species { get; set; }
        public string Name_Gender { get; set; }
        public string Age_Patient { get; set; }
        public string Name_Client { get; set; }
        public string Address_Client { get; set; }
        public string ContactNumber_Client { get; set; }
        public string ContactNumber2_Client { get; set; }
        public string Email_Client { get; set; }
        public int? ID_Company { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string Name_Company { get; set; }
        public string Address_Company { get; set; }
        public string ContactNumber_Company { get; set; }
        public string HeaderInfo_Company { get; set; }
    }
}
