using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class BeastfriendForImport
    {
        public string ITEM_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? STNDCOST { get; set; }
        public double? LISTPRICE { get; set; }
        public string CATEGORY { get; set; }
    }
}
