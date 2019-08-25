using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAvailability
    {
        public decimal WebAvailabilityId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string IsHatching { get; set; }
        public decimal? EstAvailability { get; set; }
        public string LimitedBasis { get; set; }
        public decimal? LimitedMagnitude { get; set; }
        public string HatchRestart { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Waitlistable { get; set; }
        public decimal BreedId { get; set; }

        public virtual Breed Breed { get; set; }
    }
}
