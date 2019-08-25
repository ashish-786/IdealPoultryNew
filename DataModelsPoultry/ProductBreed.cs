using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductBreed
    {
        public ProductBreed()
        {
            ProductBreedProduct = new HashSet<ProductBreedProduct>();
        }

        public decimal ProductBreedId { get; set; }
        public string Description { get; set; }
        public decimal LeftWebImageId { get; set; }
        public decimal? RightWebImageId { get; set; }
        public string ShowOnWeb { get; set; }
        public decimal? WebAttrGroupId { get; set; }

        public virtual ICollection<ProductBreedProduct> ProductBreedProduct { get; set; }
    }
}
