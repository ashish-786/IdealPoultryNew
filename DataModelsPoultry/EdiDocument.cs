using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiDocument
    {
        public EdiDocument()
        {
            EdiPoHdr = new HashSet<EdiPoHdr>();
        }

        public decimal EdiDocumentId { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal ControlNumber { get; set; }
        public string UsageIndicator { get; set; }
        public string Document { get; set; }
        public string Acknowledged { get; set; }
        public string Status { get; set; }
        public decimal EdiPartnerId { get; set; }
        public string Direction { get; set; }

        public virtual EdiPartner EdiPartner { get; set; }
        public virtual ICollection<EdiPoHdr> EdiPoHdr { get; set; }
    }
}
