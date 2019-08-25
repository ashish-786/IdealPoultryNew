using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class MemoDtl
    {
        public decimal MemoDtlId { get; set; }
        public decimal MemoHdrId { get; set; }
        public decimal SuborderDtlId { get; set; }
        public decimal RefundedPrice { get; set; }
        public decimal RefundedQuantity { get; set; }
        public decimal MemoReasonId { get; set; }
        public decimal RefundedServices { get; set; }

        public virtual MemoHdr MemoHdr { get; set; }
        public virtual MemoReason MemoReason { get; set; }
        public virtual SuborderDtl SuborderDtl { get; set; }
    }
}
