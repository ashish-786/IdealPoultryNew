using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Suborder
    {
        public Suborder()
        {
            BoxHdr = new HashSet<BoxHdr>();
            SuborderDtl = new HashSet<SuborderDtl>();
        }

        public decimal SuborderId { get; set; }
        public decimal OrderId { get; set; }
        public string PoNumber { get; set; }

        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<BoxHdr> BoxHdr { get; set; }
        public virtual ICollection<SuborderDtl> SuborderDtl { get; set; }
    }
}
