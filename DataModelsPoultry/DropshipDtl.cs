using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class DropshipDtl
    {
        public decimal DropshipDtlId { get; set; }
        public decimal DropshipId { get; set; }
        public decimal SuborderId { get; set; }
        public string PoNumber { get; set; }
        public string OutsourceId { get; set; }
        public decimal SuborderDtlId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Reported { get; set; }
        public decimal ShipdayId { get; set; }

        public virtual DropshipHdr Dropship { get; set; }
        public virtual Product Product { get; set; }
        public virtual ShipdayHdr Shipday { get; set; }
    }
}
