using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ActivityDtl
    {
        public decimal ActivityDtlId { get; set; }
        public decimal ActivityId { get; set; }
        public decimal OrderId { get; set; }
        public decimal Amount { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual OrderHdr Order { get; set; }
    }
}
