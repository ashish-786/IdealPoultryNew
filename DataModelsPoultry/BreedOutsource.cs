using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedOutsource
    {
        public decimal BreedAvailabilityId { get; set; }
        public string Source { get; set; }
        public int Quantity { get; set; }
        public string Sexable { get; set; }
    }
}
