using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedAvailability
    {
        public BreedAvailability()
        {
            BreedTray = new HashSet<BreedTray>();
        }

        public decimal BreedAvailabilityId { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal BreedId { get; set; }
        public byte SexableEggYield { get; set; }
        public int SexableEggCount { get; set; }
        public int SexableChickCount { get; set; }
        public byte NonsexableEggYield { get; set; }
        public int NonsexableEggCount { get; set; }
        public int NonsexableChickCount { get; set; }
        public int BalutChickCount { get; set; }

        public virtual ICollection<BreedTray> BreedTray { get; set; }
    }
}
