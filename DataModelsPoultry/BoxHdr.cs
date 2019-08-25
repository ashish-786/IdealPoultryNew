using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BoxHdr
    {
        public BoxHdr()
        {
            BoxDtl = new HashSet<BoxDtl>();
        }

        public decimal BoxId { get; set; }
        public decimal SuborderId { get; set; }
        public decimal Sequence { get; set; }
        public string TrackingInfo { get; set; }
        public decimal? BundleId { get; set; }
        public decimal BoxWeight { get; set; }
        public string PrintShippingLabel { get; set; }
        public string OutsourceId { get; set; }

        public virtual Suborder Suborder { get; set; }
        public virtual ICollection<BoxDtl> BoxDtl { get; set; }
    }
}
