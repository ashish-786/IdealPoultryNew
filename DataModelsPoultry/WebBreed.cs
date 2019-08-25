using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebBreed
    {
        public WebBreed()
        {
            WebCategoryBreed = new HashSet<WebCategoryBreed>();
        }

        public decimal WebBreedId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WebCategoryBreed> WebCategoryBreed { get; set; }
    }
}
