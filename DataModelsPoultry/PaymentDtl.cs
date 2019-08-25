using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class PaymentDtl
    {
        public decimal PaymentDtlId { get; set; }
        public decimal PaymentHdrId { get; set; }
        public decimal ActivityId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual PaymentHdr PaymentHdr { get; set; }
    }
}
