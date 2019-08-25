using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Specials
    {
        public decimal SpecialId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string IgnoreFirstBreakRule { get; set; }

        public virtual Product Product { get; set; }
    }
}
