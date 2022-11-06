using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCollection_Detail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public int ID_Collection { get; set; }
        public int? ID_Doc { get; set; }
        public Guid? ID_DocModel { get; set; }
        public decimal? SIAmount { get; set; }
        public decimal? AmountCollected { get; set; }
        public decimal? InterestAmount { get; set; }
        public decimal? Balance { get; set; }
        public string DocReference { get; set; }

        public virtual tCollection ID_CollectionNavigation { get; set; }
    }
}
