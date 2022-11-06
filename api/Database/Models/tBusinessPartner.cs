using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tBusinessPartner
    {
        public tBusinessPartner()
        {
            tBusinessPartner_Contact = new HashSet<tBusinessPartner_Contact>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string TelNoA { get; set; }
        public string TelNoB { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string WebSite { get; set; }
        public int? ID_Industry { get; set; }
        public string AliasName { get; set; }
        public string TIN { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSupplier { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartner_Contact> tBusinessPartner_Contact { get; set; }
    }
}
