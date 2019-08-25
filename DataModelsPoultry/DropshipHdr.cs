using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class DropshipHdr
    {
        public DropshipHdr()
        {
            DropshipDtl = new HashSet<DropshipDtl>();
        }

        public decimal DropshipId { get; set; }
        public decimal OrderId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal CustomertypeId { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public decimal? CustomerZipcodeId { get; set; }
        public string CustomerPhone { get; set; }

        public virtual Customertype Customertype { get; set; }
        public virtual ICollection<DropshipDtl> DropshipDtl { get; set; }
    }
}
