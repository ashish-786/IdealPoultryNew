using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerCalllist
    {
        public decimal CustomerCalllistId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal ShipdayId { get; set; }
        public string CustomerPurchase { get; set; }
        public string Notes { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ShipdayHdr Shipday { get; set; }
    }
}
