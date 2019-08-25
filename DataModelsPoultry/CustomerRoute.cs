using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerRoute
    {
        public decimal CustomerId { get; set; }
        public decimal RouteId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Route Route { get; set; }
    }
}
