using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BoxDtl
    {
        public decimal BoxDtlId { get; set; }
        public decimal BoxId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string SpecialServicesString { get; set; }

        public virtual BoxHdr Box { get; set; }
        public virtual Product Product { get; set; }
    }
}
