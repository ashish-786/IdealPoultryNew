using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Zipcode
    {
        public Zipcode()
        {
            Customer = new HashSet<Customer>();
            CustomerCreditcard = new HashSet<CustomerCreditcard>();
            Hatchery = new HashSet<Hatchery>();
        }

        public decimal ZipcodeId { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime? LastValidation { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<CustomerCreditcard> CustomerCreditcard { get; set; }
        public virtual ICollection<Hatchery> Hatchery { get; set; }
    }
}
