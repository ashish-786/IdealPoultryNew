using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class PostalWeight
    {
        public decimal PostalWeightId { get; set; }
        public string PostalZone { get; set; }
        public decimal Pounds { get; set; }
        public decimal PostalCharge { get; set; }
        public decimal OrderTypeId { get; set; }

        public virtual OrderType OrderType { get; set; }
    }
}
