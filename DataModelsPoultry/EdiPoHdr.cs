using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiPoHdr
    {
        public EdiPoHdr()
        {
            EdiPoDtl = new HashSet<EdiPoDtl>();
        }

        public decimal EdiPoHdrId { get; set; }
        public decimal EdiDocumentId { get; set; }
        public string DocumentType { get; set; }
        public string PoNumber { get; set; }
        public DateTime PoGenerationDate { get; set; }
        public DateTime? DoNotDeliverBefore { get; set; }
        public DateTime? DoNotDeliverAfter { get; set; }
        public DateTime? ChangeOrderDate { get; set; }
        public string ChangeOrderPurpose { get; set; }
        public string PartnerCustomerId { get; set; }
        public string Imported { get; set; }
        public string Acknowledged { get; set; }
        public string GroupNumber { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual EdiDocument EdiDocument { get; set; }
        public virtual ICollection<EdiPoDtl> EdiPoDtl { get; set; }
    }
}
