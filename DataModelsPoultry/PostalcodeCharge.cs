using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class PostalcodeCharge
    {
        public decimal PostalcodeChargeId { get; set; }
        public decimal PostalcodeId { get; set; }
        public decimal PostalZone { get; set; }
        public decimal MaximumQuantity { get; set; }
        public decimal Charge { get; set; }

        public virtual Postalcode Postalcode { get; set; }
    }
}
