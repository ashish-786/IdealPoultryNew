using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CartDtl
    {
        public CartDtl()
        {
            CartDtlAttrib = new HashSet<CartDtlAttrib>();
        }

        public decimal CartDtlId { get; set; }
        public decimal CartId { get; set; }
        public decimal Quantity { get; set; }
        public decimal ProductId { get; set; }
        public decimal Price { get; set; }
        public string Available { get; set; }

        public virtual CartHdr Cart { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<CartDtlAttrib> CartDtlAttrib { get; set; }
    }
}
