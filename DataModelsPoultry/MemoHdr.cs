using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class MemoHdr
    {
        public MemoHdr()
        {
            MemoDtl = new HashSet<MemoDtl>();
        }

        public decimal MemoHdrId { get; set; }
        public decimal OrderId { get; set; }
        public decimal? ActivityId { get; set; }
        public decimal MemoStatusId { get; set; }
        public DateTime MemoDate { get; set; }
        public string Notes { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual MemoStatus MemoStatus { get; set; }
        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<MemoDtl> MemoDtl { get; set; }
    }
}
