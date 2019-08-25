using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebOrderDtlAttr
    {
        public decimal WebOrderDtlAttrId { get; set; }
        public decimal WebOrderDtlId { get; set; }
        public decimal WebAttrDtlId { get; set; }
        public decimal PriceModifier { get; set; }

        public virtual WebAttrDtl WebAttrDtl { get; set; }
        public virtual WebOrderDtl WebOrderDtl { get; set; }
    }
}
