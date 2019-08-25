using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class AttribDtl
    {
        public AttribDtl()
        {
            CartDtlAttrib = new HashSet<CartDtlAttrib>();
        }

        public decimal AttribDtlId { get; set; }
        public decimal AttribHdrId { get; set; }
        public decimal SortOrder { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal PriceModifier { get; set; }
        public decimal? SpecialServiceId { get; set; }

        public virtual SpecialService SpecialService { get; set; }
        public virtual ICollection<CartDtlAttrib> CartDtlAttrib { get; set; }
    }
}
