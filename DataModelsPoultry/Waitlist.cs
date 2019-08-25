using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Waitlist
    {
        public decimal WaitlistId { get; set; }
        public DateTime WaitlistDate { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public decimal ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string AnyPreviousOrders { get; set; }
        public DateTime? PreviousOrderDate { get; set; }
        public string IsWholesaleCustomer { get; set; }
        public decimal? CustomerId { get; set; }
        public string Notes { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
