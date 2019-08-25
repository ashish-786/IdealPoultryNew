using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiInvoiceHdr
    {
        public decimal EdiInvoiceHdrId { get; set; }
        public decimal OrderId { get; set; }
        public string GroupNumber { get; set; }
        public string TransactionNumber { get; set; }
        public string Acknowledged { get; set; }
    }
}
