using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Paymentterm
    {
        public Paymentterm()
        {
            Customer = new HashSet<Customer>();
        }

        public decimal PaymenttermId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? MonthlyFinanceCharge { get; set; }
        public string ChargeCod { get; set; }
        public string OnlyShipCod { get; set; }
        public string PerformCloseout { get; set; }
        public string IsCreditCardTerm { get; set; }
        public string IsPaypalTerm { get; set; }
        public string Inactive { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
