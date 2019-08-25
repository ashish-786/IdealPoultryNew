using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Eastercode
    {
        public Eastercode()
        {
            InverseSortParent = new HashSet<Eastercode>();
            Product = new HashSet<Product>();
        }

        public decimal EastercodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? SortParentId { get; set; }

        public virtual Eastercode SortParent { get; set; }
        public virtual ICollection<Eastercode> InverseSortParent { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
