using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Pricesheet
    {
        public Pricesheet()
        {
            Customer = new HashSet<Customer>();
            Customertype = new HashSet<Customertype>();
            HundredPricing = new HashSet<HundredPricing>();
            InverseDefaultPricesheet = new HashSet<Pricesheet>();
            ProductClass = new HashSet<ProductClass>();
            ProductPricing = new HashSet<ProductPricing>();
            WebCategory = new HashSet<WebCategory>();
        }

        public decimal PricesheetId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? SocAmount { get; set; }
        public decimal? DefaultPricesheetId { get; set; }
        public string IsRetailDefault { get; set; }
        public string Inactive { get; set; }

        public virtual Pricesheet DefaultPricesheet { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Customertype> Customertype { get; set; }
        public virtual ICollection<HundredPricing> HundredPricing { get; set; }
        public virtual ICollection<Pricesheet> InverseDefaultPricesheet { get; set; }
        public virtual ICollection<ProductClass> ProductClass { get; set; }
        public virtual ICollection<ProductPricing> ProductPricing { get; set; }
        public virtual ICollection<WebCategory> WebCategory { get; set; }
    }
}
