using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductBreakpoint
    {
        public ProductBreakpoint()
        {
            ProductPricing = new HashSet<ProductPricing>();
        }

        public decimal ProductBreakpointId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<ProductPricing> ProductPricing { get; set; }
    }
}
