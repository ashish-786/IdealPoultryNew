using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CodCard
    {
        public decimal OrderId { get; set; }
        public string CodNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal CodCardId { get; set; }

        public virtual OrderHdr Order { get; set; }
    }
}
