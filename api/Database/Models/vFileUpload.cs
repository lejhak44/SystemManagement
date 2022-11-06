using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vFileUpload
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
        public Guid? ID_Model { get; set; }
        public string Path { get; set; }
        public string ID_CurrentObject { get; set; }
        public string FileName { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
