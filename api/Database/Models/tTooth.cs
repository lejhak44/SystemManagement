using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tTooth
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int? ToothNumber { get; set; }
        public string Location { get; set; }
        public int? Top_ID_ToothSurface { get; set; }
        public int? Left_ID_ToothSurface { get; set; }
        public int? Middle_ID_ToothSurface { get; set; }
        public int? Bottom_ID_ToothSurface { get; set; }
        public int? Right_ID_ToothSurface { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_Dentition { get; set; }
        public int? ID_TeethQuandrant { get; set; }
    }
}
