using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class SuggestiveSell
    {
        public decimal SuggestiveSellId { get; set; }
        public decimal ProductId { get; set; }
        public DateTime BegDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte SortOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
