using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tModel_Property
    {
        public _tModel_Property()
        {
            InverseID_ModelProperty_KeyNavigation = new HashSet<_tModel_Property>();
            _tDetailView_Detail = new HashSet<_tDetailView_Detail>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Caption { get; set; }
        public Guid ID_Model { get; set; }
        public int? ID_PropertyType { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? ID_PropertyModel { get; set; }
        public Guid? ID_ModelProperty_Key { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsAggregated { get; set; }
        public string DisplayProperty { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual _tModel ID_ModelNavigation { get; set; }
        public virtual _tModel_Property ID_ModelProperty_KeyNavigation { get; set; }
        public virtual _tModel ID_PropertyModelNavigation { get; set; }
        public virtual ICollection<_tModel_Property> InverseID_ModelProperty_KeyNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> _tDetailView_Detail { get; set; }
    }
}
