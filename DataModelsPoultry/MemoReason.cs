using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class MemoReason
    {
        public MemoReason()
        {
            MemoDtl = new HashSet<MemoDtl>();
        }

        public decimal MemoReasonId { get; set; }
        public string Description { get; set; }
        public decimal SortOrder { get; set; }

        public virtual ICollection<MemoDtl> MemoDtl { get; set; }
    }
}
