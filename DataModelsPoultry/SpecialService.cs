using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class SpecialService
    {
        public SpecialService()
        {
            AttribDtl = new HashSet<AttribDtl>();
            WebAttrDtl = new HashSet<WebAttrDtl>();
        }

        public decimal SpecialServiceId { get; set; }
        public decimal OffsetId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string IsVaccinate { get; set; }
        public decimal? SortOrder { get; set; }

        public virtual Offset Offset { get; set; }
        public virtual WebSpecialService WebSpecialService { get; set; }
        public virtual ICollection<AttribDtl> AttribDtl { get; set; }
        public virtual ICollection<WebAttrDtl> WebAttrDtl { get; set; }
    }
}
