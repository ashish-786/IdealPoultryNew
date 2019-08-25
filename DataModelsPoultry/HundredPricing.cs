using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class HundredPricing
    {
        public decimal PricesheetId { get; set; }
        public decimal PostalcodeId { get; set; }

        public virtual Postalcode Postalcode { get; set; }
        public virtual Pricesheet Pricesheet { get; set; }
    }
}
