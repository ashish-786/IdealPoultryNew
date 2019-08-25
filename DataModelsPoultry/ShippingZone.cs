using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ShippingZone
    {
        public string Zip { get; set; }
        public string Zone { get; set; }
        public string UseAirmail { get; set; }
        public decimal ShippingLocationId { get; set; }
        public string ShippingTime { get; set; }
        public string PrintTime { get; set; }
        public decimal ShippingTruckId { get; set; }

        public virtual ShippingLocation ShippingLocation { get; set; }
        public virtual ShippingTruck ShippingTruck { get; set; }
    }
}
