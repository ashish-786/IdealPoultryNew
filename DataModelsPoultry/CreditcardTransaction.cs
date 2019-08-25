using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CreditcardTransaction
    {
        public decimal CreditcardTransactionId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal TransactionType { get; set; }
        public string ResponseText { get; set; }
        public string TransactionId { get; set; }
        public decimal? BillingId { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal? ActivityId { get; set; }
        public string ReferenceTransactionId { get; set; }
        public string Approved { get; set; }
        public string Last4 { get; set; }
        public decimal? OrderId { get; set; }
        public decimal? CustomerCreditcardId { get; set; }

        public virtual Customer Billing { get; set; }
        public virtual CustomerCreditcard CustomerCreditcard { get; set; }
        public virtual CreditcardTransactionType TransactionTypeNavigation { get; set; }
    }
}
