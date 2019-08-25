using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebBreedItem
    {
        public decimal WebBreedId { get; set; }
        public decimal WebItemId { get; set; }
        public decimal SortOrder { get; set; }

        public virtual WebItem WebItem { get; set; }
    }
}
