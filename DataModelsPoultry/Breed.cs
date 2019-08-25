using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Breed
    {
        public Breed()
        {
            BreedAttributeDtl = new HashSet<BreedAttributeDtl>();
            BreedDescription = new HashSet<BreedDescription>();
            BreedMakeupBreed = new HashSet<BreedMakeup>();
            BreedMakeupMemberBreed = new HashSet<BreedMakeup>();
            BreedMasterBreed = new HashSet<BreedMaster>();
            BreedMasterMasterBreed = new HashSet<BreedMaster>();
            CustomAvailDetail = new HashSet<CustomAvailDetail>();
            Product = new HashSet<Product>();
            ProductClassMember = new HashSet<ProductClassMember>();
            WebAvailability = new HashSet<WebAvailability>();
        }

        public decimal BreedId { get; set; }
        public string Description { get; set; }
        public byte AvailStraightRunFactor { get; set; }
        public byte AvailPulletFactor { get; set; }
        public byte AvailMaleFactor { get; set; }
        public byte SortOrder { get; set; }
        public string Inactive { get; set; }
        public string ShowInAvailability { get; set; }
        public string IsTotalOnly { get; set; }
        public decimal? ShipdayCodeId { get; set; }
        public decimal? PostalcodeId { get; set; }
        public decimal? OffsetId { get; set; }
        public string Code { get; set; }
        public string CheckAvailability { get; set; }
        public string HighlightOnReport { get; set; }
        public decimal? AttribGroupHdrId { get; set; }
        public byte MinimumOrderQuantity { get; set; }
        public decimal BreedTypeId { get; set; }
        public string ShowOnWeb { get; set; }
        public string DropShipOnly { get; set; }

        public virtual AttribGroupHdr AttribGroupHdr { get; set; }
        public virtual BreedType BreedType { get; set; }
        public virtual Offset Offset { get; set; }
        public virtual Postalcode Postalcode { get; set; }
        public virtual ShipdayCode ShipdayCode { get; set; }
        public virtual ICollection<BreedAttributeDtl> BreedAttributeDtl { get; set; }
        public virtual ICollection<BreedDescription> BreedDescription { get; set; }
        public virtual ICollection<BreedMakeup> BreedMakeupBreed { get; set; }
        public virtual ICollection<BreedMakeup> BreedMakeupMemberBreed { get; set; }
        public virtual ICollection<BreedMaster> BreedMasterBreed { get; set; }
        public virtual ICollection<BreedMaster> BreedMasterMasterBreed { get; set; }
        public virtual ICollection<CustomAvailDetail> CustomAvailDetail { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductClassMember> ProductClassMember { get; set; }
        public virtual ICollection<WebAvailability> WebAvailability { get; set; }
    }
}
