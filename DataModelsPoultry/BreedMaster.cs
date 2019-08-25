using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedMaster
    {
        public decimal BreedId { get; set; }
        public decimal MasterBreedId { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual Breed MasterBreed { get; set; }
    }
}
