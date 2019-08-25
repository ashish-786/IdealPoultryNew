using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAttrDtl
    {
        public WebAttrDtl()
        {
            WebOrderDtlAttr = new HashSet<WebOrderDtlAttr>();
        }

        public decimal WebAttrDtlId { get; set; }
        public decimal WebAttrId { get; set; }
        public decimal SequenceNumber { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal PriceModifier { get; set; }
        public decimal? SpecialServiceId { get; set; }

        public virtual SpecialService SpecialService { get; set; }
        public virtual WebAttr WebAttr { get; set; }
        public virtual ICollection<WebOrderDtlAttr> WebOrderDtlAttr { get; set; }
    }
}
