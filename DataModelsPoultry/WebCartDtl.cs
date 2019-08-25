using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebCartDtl
    {
        public decimal WebCartId { get; set; }
        public decimal ItemSequence { get; set; }
        public decimal Qty { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal EachPrice { get; set; }
        public decimal ProductId { get; set; }
        public string Availability { get; set; }
        public string Category { get; set; }
        public decimal ItemId { get; set; }
        public string NoSellReason { get; set; }
        public string Processed { get; set; }
        public decimal WebCartDtlId { get; set; }
        public decimal? WebCategoryId { get; set; }
    }
}
