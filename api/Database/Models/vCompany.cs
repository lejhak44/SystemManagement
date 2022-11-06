using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class vCompany
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
        public int? ID_Country { get; set; }
        public string Address { get; set; }
        public string ImageLogoFilename { get; set; }
        public string ContactNumber { get; set; }
        public string ImageHeaderFilename { get; set; }
        public string Email { get; set; }
        public bool? IsShowPOSReceiptLogo { get; set; }
        public string SOAPPlanSMSMessage { get; set; }
        public bool? IsRemoveBoldText { get; set; }
        public bool? IsShowHeader { get; set; }
        public string POSReceiptFontSize { get; set; }
        public string SecurityPIN { get; set; }
        public bool? IsShowPaymentLabel { get; set; }
        public bool? IsShowPaymentWarningLabel { get; set; }
        public int? ID_PackagePlan { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string ImageHeaderLocationFilenamePath { get; set; }
        public string ImageHeaderThumbNameLocationFilenamePath { get; set; }
        public string ImageLogoLocationFilenamePath { get; set; }
        public string ImageLogoThumbNameLocationFilenamePath { get; set; }
    }
}
