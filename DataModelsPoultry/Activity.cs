using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityDtl = new HashSet<ActivityDtl>();
            MemoHdr = new HashSet<MemoHdr>();
            PaymentDtl = new HashSet<PaymentDtl>();
        }

        public decimal ActivityId { get; set; }
        public DateTime ActivityDate { get; set; }
        public decimal BillingId { get; set; }
        public decimal ActivityTypeId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? OrderId { get; set; }
        public string PoNumber { get; set; }
        public string CheckNumber { get; set; }
        public string IsPosted { get; set; }
        public decimal? ActivitySessionId { get; set; }
        public decimal Amount { get; set; }
        public string EntryType { get; set; }

        public virtual ActivitySession ActivitySession { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual Customer Billing { get; set; }
        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<ActivityDtl> ActivityDtl { get; set; }
        public virtual ICollection<MemoHdr> MemoHdr { get; set; }
        public virtual ICollection<PaymentDtl> PaymentDtl { get; set; }
    }
}
