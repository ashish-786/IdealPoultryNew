using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductClassMember
    {
        public decimal ProductClassId { get; set; }
        public decimal BreedId { get; set; }
        public byte SortOrder { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual ProductClass ProductClass { get; set; }
    }
}
