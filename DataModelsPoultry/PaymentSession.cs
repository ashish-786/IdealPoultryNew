using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class PaymentSession
    {
        public PaymentSession()
        {
            PaymentHdr = new HashSet<PaymentHdr>();
        }

        public decimal PaymentSessionId { get; set; }
        public decimal PersonId { get; set; }
        public DateTime DateStarted { get; set; }
        public string IsPosted { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<PaymentHdr> PaymentHdr { get; set; }
    }
}
