using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public string ProductTypeId { get; set; }
        public string Description { get; set; }
        public string IsPoultryItem { get; set; }
        public string CheckAvailability { get; set; }
        public bool? AvailabilityModifier { get; set; }
        public string IsEggItem { get; set; }
        public string IsStraightRun { get; set; }
        public string IsPullet { get; set; }
        public string IsMale { get; set; }
        public decimal SortOrder { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
