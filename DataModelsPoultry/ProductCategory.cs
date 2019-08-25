using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductClassCategory = new HashSet<ProductClassCategory>();
        }

        public decimal ProductCategoryId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductClassCategory> ProductClassCategory { get; set; }
    }
}
