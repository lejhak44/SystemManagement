using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCollection
    {
        public tCollection()
        {
            tCollection_Detail = new HashSet<tCollection_Detail>();
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
        public int ID_BusinessPartner { get; set; }
        public DateTime? Date { get; set; }
        public string ManualDocNo { get; set; }
        public int? ID_ReceiptType { get; set; }
        public int? ID_BankAccount { get; set; }
        public int? ID_FilingStatus { get; set; }
        public string CancellationReason { get; set; }

        public virtual tBusinessPartner ID_BusinessPartnerNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCollection_Detail> tCollection_Detail { get; set; }
    }
}
