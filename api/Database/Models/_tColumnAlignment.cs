using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tColumnAlignment
    {
        public _tColumnAlignment()
        {
            _tListView_Detail = new HashSet<_tListView_Detail>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<_tListView_Detail> _tListView_Detail { get; set; }
    }
}
