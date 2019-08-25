using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebBlackout
    {
        public decimal WebBlackoutId { get; set; }
        public decimal ProductId { get; set; }
        public decimal ShipdayId { get; set; }
        public string Notes { get; set; }

        public virtual Product Product { get; set; }
        public virtual ShipdayHdr Shipday { get; set; }
    }
}
