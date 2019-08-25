using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class MemoStatus
    {
        public MemoStatus()
        {
            MemoHdr = new HashSet<MemoHdr>();
        }

        public decimal MemoStatusId { get; set; }
        public string Description { get; set; }
        public decimal Status { get; set; }
        public decimal SortOrder { get; set; }
        public decimal? ActivityTypeId { get; set; }

        public virtual ActivityType ActivityType { get; set; }
        public virtual ICollection<MemoHdr> MemoHdr { get; set; }
    }
}
