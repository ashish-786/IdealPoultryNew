using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductPricing
    {
        public decimal ProductPricingId { get; set; }
        public decimal ProductBreakpointId { get; set; }
        public decimal PricesheetId { get; set; }
        public decimal ProductPricedateId { get; set; }
        public decimal Price { get; set; }

        public virtual Pricesheet Pricesheet { get; set; }
        public virtual ProductBreakpoint ProductBreakpoint { get; set; }
        public virtual ProductPricedate ProductPricedate { get; set; }
    }
}
