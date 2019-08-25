using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedDescription
    {
        public decimal BreedDescriptionId { get; set; }
        public decimal Sequence { get; set; }
        public decimal Flags { get; set; }
        public string Text { get; set; }
        public decimal BreedId { get; set; }
        public string DescriptionType { get; set; }

        public virtual Breed Breed { get; set; }
    }
}
