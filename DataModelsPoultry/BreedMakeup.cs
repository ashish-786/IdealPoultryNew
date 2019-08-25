using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedMakeup
    {
        public decimal BreedId { get; set; }
        public decimal MemberBreedId { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual Breed MemberBreed { get; set; }
    }
}
