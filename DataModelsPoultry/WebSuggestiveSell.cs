using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebSuggestiveSell
    {
        public decimal WebSuggestiveSellId { get; set; }
        public decimal WebItemProductId { get; set; }
        public DateTime FromDate { get; set; }
        public decimal SortOrder { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual WebItemProduct WebItemProduct { get; set; }
    }
}
