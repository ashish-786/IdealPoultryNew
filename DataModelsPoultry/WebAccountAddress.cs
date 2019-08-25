using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAccountAddress
    {
        public decimal WebAccountId { get; set; }
        public decimal WebAddressId { get; set; }
        public string AddressType { get; set; }

        public virtual WebAccount WebAccount { get; set; }
        public virtual WebAddress WebAddress { get; set; }
    }
}
