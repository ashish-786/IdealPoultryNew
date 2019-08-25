using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Availability
    {
        public Availability()
        {
            AvailabilityOutsource = new HashSet<AvailabilityOutsource>();
        }

        public decimal AvailabilityId { get; set; }
        public decimal ProductId { get; set; }
        public decimal? EggsInTray1 { get; set; }
        public decimal? NumberOfTray1 { get; set; }
        public decimal? YieldTray1 { get; set; }
        public decimal? EggsInTray2 { get; set; }
        public decimal? NumberOfTray2 { get; set; }
        public decimal? YieldTray2 { get; set; }
        public decimal? Eggs { get; set; }
        public decimal? EggsYield { get; set; }
        public decimal? BalutTrays { get; set; }
        public decimal? BalutChicks { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal? Chicks { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<AvailabilityOutsource> AvailabilityOutsource { get; set; }
    }
}
