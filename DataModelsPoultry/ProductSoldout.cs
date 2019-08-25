using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ProductSoldout
    {
        public decimal ProductId { get; set; }
        public DateTime ShipDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
