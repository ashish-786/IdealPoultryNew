using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebOrderDtl
    {
        public WebOrderDtl()
        {
            WebOrderDtlAttr = new HashSet<WebOrderDtlAttr>();
        }

        public decimal WebOrderDtlId { get; set; }
        public decimal WebOrderHdrId { get; set; }
        public decimal LineNumber { get; set; }
        public decimal WebItemProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal EachPrice { get; set; }
        public string Availability { get; set; }

        public virtual WebItemProduct WebItemProduct { get; set; }
        public virtual WebOrderHdr WebOrderHdr { get; set; }
        public virtual ICollection<WebOrderDtlAttr> WebOrderDtlAttr { get; set; }
    }
}
