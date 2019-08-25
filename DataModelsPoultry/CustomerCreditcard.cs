using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerCreditcard
    {
        public CustomerCreditcard()
        {
            CreditcardTransaction = new HashSet<CreditcardTransaction>();
            OrderHdr = new HashSet<OrderHdr>();
        }

        public decimal CustomerCreditcardId { get; set; }
        public decimal CustomerId { get; set; }
        public string NameOnCard { get; set; }
        public string BillingAddress { get; set; }
        public decimal? BillingZipcodeId { get; set; }
        public byte[] CcNumber { get; set; }
        public byte[] CcCvv { get; set; }
        public byte[] CcExpirationMonth { get; set; }
        public byte[] CcExpirationYear { get; set; }
        public string WasLastUsed { get; set; }
        public string Inactive { get; set; }

        public virtual Zipcode BillingZipcode { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CreditcardTransaction> CreditcardTransaction { get; set; }
        public virtual ICollection<OrderHdr> OrderHdr { get; set; }
    }
}
