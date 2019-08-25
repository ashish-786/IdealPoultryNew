using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiPartner
    {
        public EdiPartner()
        {
            EdiDocument = new HashSet<EdiDocument>();
            EdiTranslation = new HashSet<EdiTranslation>();
            OrderHdr = new HashSet<OrderHdr>();
        }

        public decimal EdiPartnerId { get; set; }
        public string Qualifier { get; set; }
        public string Identifier { get; set; }
        public decimal CustomerId { get; set; }
        public string Notes { get; set; }
        public decimal? HatcheryId { get; set; }
        public decimal? CustomertypeId { get; set; }
        public byte? BillingTermDays { get; set; }
        public string BillingTermDescription { get; set; }
        public string PartnerIdForUs { get; set; }
        public string ShortName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Customertype Customertype { get; set; }
        public virtual Hatchery Hatchery { get; set; }
        public virtual ICollection<EdiDocument> EdiDocument { get; set; }
        public virtual ICollection<EdiTranslation> EdiTranslation { get; set; }
        public virtual ICollection<OrderHdr> OrderHdr { get; set; }
    }
}
