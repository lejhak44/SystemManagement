using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vTooth
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
        public string Top_Name_ToothSurface { get; set; }
        public string Left_Name_ToothSurface { get; set; }
        public string Middle_Name_ToothSurface { get; set; }
        public string Bottom_Name_ToothSurface { get; set; }
        public string Right_Name_ToothSurface { get; set; }
        public int? ID_Dentition { get; set; }
        public string Name_Dentition { get; set; }
        public int? ID_TeethQuandrant { get; set; }
    }
}
