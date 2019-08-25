using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Person
    {
        public Person()
        {
            ActivitySession = new HashSet<ActivitySession>();
            CustomerNote = new HashSet<CustomerNote>();
            PaymentSession = new HashSet<PaymentSession>();
        }

        public decimal PersonId { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string EnterOrders { get; set; }
        public string ItemMaintenance { get; set; }
        public string EnterAccounting { get; set; }
        public string SendMessages { get; set; }
        public string IgnoreLockout { get; set; }
        public string DeleteCustomer { get; set; }
        public string ProcessCreditcards { get; set; }
        public string PerformShipping { get; set; }
        public string CanShutdownApp { get; set; }
        public string CanUnpostInvoice { get; set; }
        public string CanResubmitEdi { get; set; }
        public string RecallCustomer { get; set; }
        public string Inactive { get; set; }
        public string CanMergeCustomers { get; set; }

        public virtual ICollection<ActivitySession> ActivitySession { get; set; }
        public virtual ICollection<CustomerNote> CustomerNote { get; set; }
        public virtual ICollection<PaymentSession> PaymentSession { get; set; }
    }
}
