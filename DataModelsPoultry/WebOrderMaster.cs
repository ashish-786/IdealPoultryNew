using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebOrderMaster
    {
        public WebOrderMaster()
        {
            WebOrderHdr = new HashSet<WebOrderHdr>();
        }

        public decimal WebOrderMasterId { get; set; }
        public DateTime DateReceived { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Email { get; set; }
        public byte[] CcNumber { get; set; }
        public byte[] CcExpMonth { get; set; }
        public byte[] CcExpYear { get; set; }
        public byte[] CcCvv { get; set; }
        public decimal? BillingWebAddressId { get; set; }
        public decimal? ShippingWebAddressId { get; set; }
        public decimal? CustomerId { get; set; }
        public DateTime RequestedShipDate { get; set; }
        public string Status { get; set; }
        public string RequestContactPhone { get; set; }
        public string RequestContactEmail { get; set; }
        public string LocalPickup { get; set; }
        public string Comments { get; set; }
        public string PaymentMethod { get; set; }
        public string ShipEarly { get; set; }
        public DateTime ComputedShipDate { get; set; }
        public decimal? OrderHdrId { get; set; }

        public virtual WebAddress BillingWebAddress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual OrderHdr OrderHdr { get; set; }
        public virtual WebAddress ShippingWebAddress { get; set; }
        public virtual ICollection<WebOrderHdr> WebOrderHdr { get; set; }
    }
}
