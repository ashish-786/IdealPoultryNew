using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Offsetcode
    {
        public Offsetcode()
        {
            InverseSortParent = new HashSet<Offsetcode>();
            Offset = new HashSet<Offset>();
        }

        public decimal OffsetcodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? SortParentId { get; set; }

        public virtual Offsetcode SortParent { get; set; }
        public virtual ICollection<Offsetcode> InverseSortParent { get; set; }
        public virtual ICollection<Offset> Offset { get; set; }
    }
}
