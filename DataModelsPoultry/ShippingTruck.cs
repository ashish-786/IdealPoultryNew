using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ShippingTruck
    {
        public ShippingTruck()
        {
            ShippingZone = new HashSet<ShippingZone>();
        }

        public decimal ShippingTruckId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ShippingZone> ShippingZone { get; set; }
    }
}
