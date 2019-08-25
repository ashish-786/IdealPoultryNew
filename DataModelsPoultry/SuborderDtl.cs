using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class SuborderDtl
    {
        public SuborderDtl()
        {
            MemoDtl = new HashSet<MemoDtl>();
        }

        public decimal SuborderDtlId { get; set; }
        public decimal SuborderId { get; set; }
        public decimal ProductId { get; set; }
        public string OutsourceId { get; set; }
        public decimal OutsourceLabelQuantity { get; set; }
        public decimal OutsourceReportQuantity { get; set; }
        public string Notes { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string EdiPartnerLocator { get; set; }

        public virtual Product Product { get; set; }
        public virtual Suborder Suborder { get; set; }
        public virtual ICollection<MemoDtl> MemoDtl { get; set; }
    }
}
