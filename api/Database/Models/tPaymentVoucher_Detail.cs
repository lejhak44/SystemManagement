using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tPaymentVoucher_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_PaymentVoucher { get; set; }

        public virtual tPaymentVoucher ID_PaymentVoucherNavigation { get; set; }
    }
}
