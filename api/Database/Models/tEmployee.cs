using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tEmployee
    {
        public tEmployee()
        {
            tUser = new HashSet<tUser>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string ImageFile { get; set; }
        public int? ID_Department { get; set; }
        public int? ID_EmployeePosition { get; set; }
        public int? ID_Position { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ID_Gender { get; set; }
        public string ID_EmployeeStatus { get; set; }
        public string FullAddress { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Name { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public bool? IsSystemUsed { get; set; }
        public string PRCLicenseNumber { get; set; }
        public string PTR { get; set; }
        public string S2 { get; set; }
        public string TINNumber { get; set; }
        public DateTime? DatePRCExpiration { get; set; }

        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tPosition ID_PositionNavigation { get; set; }
        public virtual ICollection<tUser> tUser { get; set; }
    }
}
