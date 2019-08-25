using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebCart
    {
        public decimal WebCartId { get; set; }
        public decimal? ShipdayId { get; set; }
        public decimal? QuarterboxCharge { get; set; }
        public decimal? SmallOrderCharge { get; set; }
        public decimal? ShippingCharge { get; set; }
    }
}
