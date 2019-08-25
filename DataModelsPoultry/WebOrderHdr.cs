using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebOrderHdr
    {
        public WebOrderHdr()
        {
            WebOrderDtl = new HashSet<WebOrderDtl>();
        }

        public decimal WebOrderHdrId { get; set; }
        public decimal? ShipdateId { get; set; }
        public decimal WebOrderMasterId { get; set; }
        public decimal BoxingCharge { get; set; }
        public decimal SmallOrderCharge { get; set; }
        public decimal SpecialServicesCharge { get; set; }
        public decimal ShippingCharge { get; set; }
        public string OrderType { get; set; }

        public virtual ShipdayHdr Shipdate { get; set; }
        public virtual WebOrderMaster WebOrderMaster { get; set; }
        public virtual ICollection<WebOrderDtl> WebOrderDtl { get; set; }
    }
}
