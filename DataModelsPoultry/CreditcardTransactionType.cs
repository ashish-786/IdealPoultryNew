using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CreditcardTransactionType
    {
        public CreditcardTransactionType()
        {
            CreditcardTransaction = new HashSet<CreditcardTransaction>();
        }

        public decimal TransactionType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CreditcardTransaction> CreditcardTransaction { get; set; }
    }
}
