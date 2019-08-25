using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductPricedate
    {
        public ProductPricedate()
        {
            ProductPricing = new HashSet<ProductPricing>();
        }

        public decimal ProductPricedateId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual ICollection<ProductPricing> ProductPricing { get; set; }
    }
}
