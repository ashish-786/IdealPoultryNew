using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductBreedProduct
    {
        public decimal ProductBreedProductId { get; set; }
        public decimal ProductBreedId { get; set; }
        public decimal ProductId { get; set; }
        public string ShowOnWeb { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductBreed ProductBreed { get; set; }
    }
}
