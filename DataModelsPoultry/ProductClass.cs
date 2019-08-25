using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductClass
    {
        public ProductClass()
        {
            ItemGroupProductClass = new HashSet<ItemGroupProductClass>();
            ProductClassCategory = new HashSet<ProductClassCategory>();
            ProductClassMember = new HashSet<ProductClassMember>();
        }

        public decimal ProductClassId { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public decimal SortOrder { get; set; }
        public decimal WebImageId { get; set; }
        public decimal RealAvailabilityWindow { get; set; }
        public decimal WebPricesheetId { get; set; }

        public virtual Pricesheet WebPricesheet { get; set; }
        public virtual ICollection<ItemGroupProductClass> ItemGroupProductClass { get; set; }
        public virtual ICollection<ProductClassCategory> ProductClassCategory { get; set; }
        public virtual ICollection<ProductClassMember> ProductClassMember { get; set; }
    }
}
