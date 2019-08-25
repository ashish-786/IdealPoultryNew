using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebItemProduct
    {
        public WebItemProduct()
        {
            WebOrderDtl = new HashSet<WebOrderDtl>();
            WebSuggestiveSell = new HashSet<WebSuggestiveSell>();
            WebWaitlist = new HashSet<WebWaitlist>();
        }

        public decimal WebItemProductId { get; set; }
        public decimal WebItemId { get; set; }
        public decimal ProductId { get; set; }
        public string ProdType { get; set; }
        public decimal? OverridePrice { get; set; }
        public string ShowOnWeb { get; set; }

        public virtual Product Product { get; set; }
        public virtual WebItem WebItem { get; set; }
        public virtual ICollection<WebOrderDtl> WebOrderDtl { get; set; }
        public virtual ICollection<WebSuggestiveSell> WebSuggestiveSell { get; set; }
        public virtual ICollection<WebWaitlist> WebWaitlist { get; set; }
    }
}
