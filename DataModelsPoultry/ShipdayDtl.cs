using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ShipdayDtl
    {
        public decimal ShipdayId { get; set; }
        public decimal ShipdayCodeId { get; set; }

        public virtual ShipdayHdr Shipday { get; set; }
        public virtual ShipdayCode ShipdayCode { get; set; }
    }
}
