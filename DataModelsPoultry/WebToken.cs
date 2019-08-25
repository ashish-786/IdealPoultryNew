using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebToken
    {
        public Guid AuthorizationToken { get; set; }
        public decimal WebAccountId { get; set; }
        public DateTime Expiry { get; set; }

        public virtual WebAccount WebAccount { get; set; }
    }
}
