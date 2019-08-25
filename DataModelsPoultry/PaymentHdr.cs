using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class PaymentHdr
    {
        public PaymentHdr()
        {
            PaymentDtl = new HashSet<PaymentDtl>();
        }

        public decimal PaymentHdrId { get; set; }
        public decimal PaymentSessionId { get; set; }
        public decimal BillingId { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Customer Billing { get; set; }
        public virtual PaymentSession PaymentSession { get; set; }
        public virtual ICollection<PaymentDtl> PaymentDtl { get; set; }
    }
}
