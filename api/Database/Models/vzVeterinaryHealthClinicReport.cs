using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vzVeterinaryHealthClinicReport
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string DestinationAddress { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        public int? ID_Item { get; set; }
        public string Name_Item { get; set; }
        public string LotNumber { get; set; }
        public int? ID_Patient { get; set; }
        public string Name_Patient { get; set; }
        public string Name_Species { get; set; }
        public string Name_Gender { get; set; }
        public string Microchip { get; set; }
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
        public int? AttendingPhysician_ID_Employee { get; set; }
        public string AttendingPhysician_Name_Employee { get; set; }
        public string TINNumber { get; set; }
        public string PTR { get; set; }
        public string PRCLicenseNumber { get; set; }
        public DateTime? DatePRCExpiration { get; set; }
    }
}
