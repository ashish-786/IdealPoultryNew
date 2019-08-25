using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebCategoryBreed
    {
        public decimal WebCategoryId { get; set; }
        public decimal WebBreedId { get; set; }
        public decimal SortOrder { get; set; }
        public string ShowOnShopPage { get; set; }

        public virtual WebBreed WebBreed { get; set; }
        public virtual WebCategory WebCategory { get; set; }
    }
}
