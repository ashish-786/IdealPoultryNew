using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Route
    {
        public Route()
        {
            CustomerRoute = new HashSet<CustomerRoute>();
        }

        public decimal RouteId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal SortOrder { get; set; }

        public virtual ICollection<CustomerRoute> CustomerRoute { get; set; }
    }
}
