using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerEastercall
    {
        public decimal CustomerId { get; set; }
        public decimal Year { get; set; }
        public string PurchaseMade { get; set; }
        public string Notes { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
