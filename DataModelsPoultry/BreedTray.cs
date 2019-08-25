using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedTray
    {
        public decimal BreedTrayId { get; set; }
        public decimal BreedAvailabilityId { get; set; }
        public byte EggsInTray { get; set; }
        public decimal NumberOfTrays { get; set; }
        public byte Yield { get; set; }
        public string Sexable { get; set; }

        public virtual BreedAvailability BreedAvailability { get; set; }
    }
}
