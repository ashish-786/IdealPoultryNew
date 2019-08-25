using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedType
    {
        public BreedType()
        {
            Breed = new HashSet<Breed>();
        }

        public decimal BreedTypeId { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }
        public byte MinimumOrderQuantity { get; set; }
        public string ErrorPrompt { get; set; }
        public string AllowWebSearch { get; set; }
        public string IsPoultryItem { get; set; }

        public virtual ICollection<Breed> Breed { get; set; }
    }
}
