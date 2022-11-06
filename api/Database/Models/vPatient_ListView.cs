using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vPatient_ListView
    {
        public int ID { get; set; }
        public int? ID_Company { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ID_Client { get; set; }
        public string Name_Client { get; set; }
        public string Email { get; set; }
        public string Species { get; set; }
        public string Name_Gender { get; set; }
        public string ContactNumber { get; set; }
        public bool? IsDeceased { get; set; }
        public DateTime? DateLastVisited { get; set; }
        public string ProfileImageThumbnailLocationFile { get; set; }
        public bool IsActive { get; set; }
        public int? WaitingStatus_ID_FilingStatus { get; set; }
        public string WaitingStatus_Name_FilingStatus { get; set; }
        public string LabelActionQueue { get; set; }
    }
}
