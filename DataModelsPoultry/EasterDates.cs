using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EasterDates
    {
        public decimal Year { get; set; }
        public decimal Date1Id { get; set; }
        public decimal Date2Id { get; set; }
        public decimal Date3Id { get; set; }
        public decimal Date4Id { get; set; }

        public virtual ShipdayHdr Date1 { get; set; }
        public virtual ShipdayHdr Date2 { get; set; }
        public virtual ShipdayHdr Date3 { get; set; }
        public virtual ShipdayHdr Date4 { get; set; }
    }
}
