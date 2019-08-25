using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiPoDtl
    {
        public decimal EdiPoDtlId { get; set; }
        public decimal EdiPoHdrId { get; set; }
        public decimal LineNumber { get; set; }
        public decimal Quantity { get; set; }
        public string Units { get; set; }
        public decimal UnitPrice { get; set; }
        public string PartnerProductId { get; set; }
        public string ChangeType { get; set; }

        public virtual EdiPoHdr EdiPoHdr { get; set; }
    }
}
