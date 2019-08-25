using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class AvailabilityOutsource
    {
        public decimal AvailabilityId { get; set; }
        public string Source { get; set; }
        public decimal Quantity { get; set; }

        public virtual Availability Availability { get; set; }
    }
}
