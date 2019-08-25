using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductClassCategory
    {
        public decimal ProductClassId { get; set; }
        public decimal ProductCategoryId { get; set; }
        public decimal SortOrder { get; set; }
        public string ShowOnShopPage { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductClass ProductClass { get; set; }
    }
}
