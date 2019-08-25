using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAccount
    {
        public WebAccount()
        {
            WebAccountAddress = new HashSet<WebAccountAddress>();
            WebToken = new HashSet<WebToken>();
        }

        public decimal WebAccountId { get; set; }
        public decimal? CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public decimal? LastBillingWebAddressId { get; set; }
        public decimal? LastShippingWebAddressId { get; set; }
        public string Password { get; set; }
        public DateTime Expiry { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual WebAddress LastBillingWebAddress { get; set; }
        public virtual WebAddress LastShippingWebAddress { get; set; }
        public virtual ICollection<WebAccountAddress> WebAccountAddress { get; set; }
        public virtual ICollection<WebToken> WebToken { get; set; }
    }
}
