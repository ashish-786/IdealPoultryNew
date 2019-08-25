using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAddress
    {
        public WebAddress()
        {
            WebAccountAddress = new HashSet<WebAccountAddress>();
            WebAccountLastBillingWebAddress = new HashSet<WebAccount>();
            WebAccountLastShippingWebAddress = new HashSet<WebAccount>();
            WebOrderMasterBillingWebAddress = new HashSet<WebOrderMaster>();
            WebOrderMasterShippingWebAddress = new HashSet<WebOrderMaster>();
        }

        public decimal WebAddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? PhoneDay { get; set; }
        public int? PhoneHome { get; set; }
        public int? PhoneCell { get; set; }
        public string Zip { get; set; }
        public decimal? FromWebAddressId { get; set; }

        public virtual ICollection<WebAccountAddress> WebAccountAddress { get; set; }
        public virtual ICollection<WebAccount> WebAccountLastBillingWebAddress { get; set; }
        public virtual ICollection<WebAccount> WebAccountLastShippingWebAddress { get; set; }
        public virtual ICollection<WebOrderMaster> WebOrderMasterBillingWebAddress { get; set; }
        public virtual ICollection<WebOrderMaster> WebOrderMasterShippingWebAddress { get; set; }
    }
}
