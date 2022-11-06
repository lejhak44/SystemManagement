using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tDeliveryReceipt_Detail_Serial
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_DeliveryReceipt_Detail { get; set; }

        public virtual tDeliveryReceipt_Detail ID_DeliveryReceipt_DetailNavigation { get; set; }
    }
}
