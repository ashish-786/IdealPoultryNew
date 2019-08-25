using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Customertype
    {
        public Customertype()
        {
            Customer = new HashSet<Customer>();
            DropshipHdr = new HashSet<DropshipHdr>();
            EdiPartner = new HashSet<EdiPartner>();
        }

        public decimal CustomertypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ChargePostage { get; set; }
        public string ChargeSoc { get; set; }
        public string ChargeQbc { get; set; }
        public string ChargeAirmail { get; set; }
        public string InsureShipment { get; set; }
        public decimal ShippingHatcheryId { get; set; }
        public decimal PricesheetId { get; set; }
        public string PrintConfirmation { get; set; }
        public string PrintShippingLabel { get; set; }
        public string IsRetailCustomer { get; set; }
        public decimal? SortOrder { get; set; }
        public decimal PackingListPrintCount { get; set; }
        public decimal InvoicePrintCount { get; set; }
        public string PrintLabelDetail { get; set; }
        public string Inactive { get; set; }
        public string IsWholesaleCustomer { get; set; }
        public string IsPaypalCustomer { get; set; }
        public string IsCreditcardCustomer { get; set; }

        public virtual Pricesheet Pricesheet { get; set; }
        public virtual Hatchery ShippingHatchery { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<DropshipHdr> DropshipHdr { get; set; }
        public virtual ICollection<EdiPartner> EdiPartner { get; set; }
    }
}
