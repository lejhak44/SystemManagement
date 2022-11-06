using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tLocalShippingPermitIssuance
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ID_Company { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public string ShippingShipper { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCategory { get; set; }
        public string ShippingSource { get; set; }
        public string ShippingPurpose { get; set; }
        public string ShippingProductSource { get; set; }
        public string ShippingLicenceNumber { get; set; }
        public string ShippingAccredationNumber { get; set; }
        public string ShippingCountryOrigin { get; set; }
        public DateTime? ProposedShippingDate { get; set; }
        public DateTime? ProposedArrivalDate { get; set; }
        public string OriginProvince { get; set; }
        public string OriginMunicipality { get; set; }
        public string OriginBarangay { get; set; }
        public string OriginEstablishment { get; set; }
        public string OriginFullAddress { get; set; }
        public string OriginSender { get; set; }
        public string OriginContactNumber { get; set; }
        public string DestinationProvince { get; set; }
        public string DestinationMunicipality { get; set; }
        public string DestinationBarangay { get; set; }
        public string DestinationEstablishment { get; set; }
        public string DestinationFullAddress { get; set; }
        public string DestinationSender { get; set; }
        public string DestinationContactNumber { get; set; }
        public bool? ModeOfTransfortationIsLand { get; set; }
        public string ModeOfTransfortationLandCarrierType { get; set; }
        public string ModeOfTransfortationLandPlateNumber { get; set; }
        public bool? ModeOfTransfortationIsAir { get; set; }
        public string ModeOfTransfortationAirCarrierType { get; set; }
        public string ModeOfTransfortationAirPlateNumber { get; set; }
        public bool? ModeOfTransfortationIsWater { get; set; }
        public string ModeOfTransfortationWaterCarrierType { get; set; }
        public string ModeOfTransfortationWaterPlateNumber { get; set; }
        public int? ID_FilingStatus { get; set; }

        public virtual tCompany ID_CompanyNavigation { get; set; }
        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
    }
}
