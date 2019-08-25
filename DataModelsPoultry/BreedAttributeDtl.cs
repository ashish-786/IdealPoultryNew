using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedAttributeDtl
    {
        public decimal BreedId { get; set; }
        public decimal BreedAttributeId { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual BreedAttribute BreedAttribute { get; set; }
    }
}
