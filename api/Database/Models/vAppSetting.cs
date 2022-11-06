using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vAppSetting
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_PropertyType { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public decimal? DecimalValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public bool? BoolValue { get; set; }
        public string ImageValue { get; set; }
        public string ColorValue { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
