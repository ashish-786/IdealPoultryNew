using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Productcolor
    {
        public Productcolor()
        {
            Product = new HashSet<Product>();
        }

        public decimal ProductcolorId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
