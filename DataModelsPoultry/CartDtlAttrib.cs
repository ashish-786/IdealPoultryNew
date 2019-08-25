using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CartDtlAttrib
    {
        public decimal CartDtlAttribId { get; set; }
        public decimal CartDtlId { get; set; }
        public decimal AttribDtlId { get; set; }

        public virtual AttribDtl AttribDtl { get; set; }
        public virtual CartDtl CartDtl { get; set; }
    }
}
