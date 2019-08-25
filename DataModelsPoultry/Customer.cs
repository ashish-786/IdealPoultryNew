using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Customer
    {
        public Customer()
        {
            Activity = new HashSet<Activity>();
            CartHdrBilling = new HashSet<CartHdr>();
            CartHdrShipping = new HashSet<CartHdr>();
            CreditcardTransaction = new HashSet<CreditcardTransaction>();
            CustomerCalllist = new HashSet<CustomerCalllist>();
            CustomerCreditcard = new HashSet<CustomerCreditcard>();
            CustomerEastercall = new HashSet<CustomerEastercall>();
            CustomerNote = new HashSet<CustomerNote>();
            CustomerRoute = new HashSet<CustomerRoute>();
            EdiPartner = new HashSet<EdiPartner>();
            InverseBilling = new HashSet<Customer>();
            OrderHdrBilling = new HashSet<OrderHdr>();
            OrderHdrCustomer = new HashSet<OrderHdr>();
            PaymentHdr = new HashSet<PaymentHdr>();
            Waitlist = new HashSet<Waitlist>();
            WebAccount = new HashSet<WebAccount>();
            WebOrderMaster = new HashSet<WebOrderMaster>();
            WebWaitlist = new HashSet<WebWaitlist>();
        }

        public decimal CustomerId { get; set; }
        public decimal BillingId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string PrintShippingLabel { get; set; }
        public string PrintPhoneNumber { get; set; }
        public decimal CustomertypeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public decimal? ZipcodeId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Contact { get; set; }
        public string AlphaSearch { get; set; }
        public DateTime? DateAdded { get; set; }
        public decimal ShippingHatcheryId { get; set; }
        public string EmailAddress { get; set; }
        public decimal? PricesheetId { get; set; }
        public decimal? PaymenttermId { get; set; }
        public string ChargePostage { get; set; }
        public string InsureShipment { get; set; }
        public string ChargeAirmail { get; set; }
        public decimal? StandardDiscount { get; set; }
        public string Rejected { get; set; }
        public string Preferred { get; set; }
        public string QuickDialNumber { get; set; }
        public string OrderingWarning { get; set; }
        public string OrderingNotes { get; set; }
        public string ShipViaAirmail { get; set; }
        public decimal? CodAdderAmount { get; set; }
        public string ChargeSoc { get; set; }
        public string ChargeQbc { get; set; }
        public string BookkeeperName { get; set; }
        public string BookkeeperPhone { get; set; }
        public string BookkeeperNotes { get; set; }
        public string PlacedbyLastName { get; set; }
        public string PlacedbyFirstName { get; set; }
        public string Inactive { get; set; }
        public string Mobile { get; set; }
        public string WebPassword { get; set; }
        public DateTime? AddressLastValidated { get; set; }
        public string WebLogin { get; set; }

        public virtual Customer Billing { get; set; }
        public virtual Customertype Customertype { get; set; }
        public virtual Paymentterm Paymentterm { get; set; }
        public virtual Pricesheet Pricesheet { get; set; }
        public virtual Hatchery ShippingHatchery { get; set; }
        public virtual Zipcode Zipcode { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<CartHdr> CartHdrBilling { get; set; }
        public virtual ICollection<CartHdr> CartHdrShipping { get; set; }
        public virtual ICollection<CreditcardTransaction> CreditcardTransaction { get; set; }
        public virtual ICollection<CustomerCalllist> CustomerCalllist { get; set; }
        public virtual ICollection<CustomerCreditcard> CustomerCreditcard { get; set; }
        public virtual ICollection<CustomerEastercall> CustomerEastercall { get; set; }
        public virtual ICollection<CustomerNote> CustomerNote { get; set; }
        public virtual ICollection<CustomerRoute> CustomerRoute { get; set; }
        public virtual ICollection<EdiPartner> EdiPartner { get; set; }
        public virtual ICollection<Customer> InverseBilling { get; set; }
        public virtual ICollection<OrderHdr> OrderHdrBilling { get; set; }
        public virtual ICollection<OrderHdr> OrderHdrCustomer { get; set; }
        public virtual ICollection<PaymentHdr> PaymentHdr { get; set; }
        public virtual ICollection<Waitlist> Waitlist { get; set; }
        public virtual ICollection<WebAccount> WebAccount { get; set; }
        public virtual ICollection<WebOrderMaster> WebOrderMaster { get; set; }
        public virtual ICollection<WebWaitlist> WebWaitlist { get; set; }
    }
}
