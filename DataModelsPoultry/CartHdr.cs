using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CartHdr
    {
        public CartHdr()
        {
            CartDtl = new HashSet<CartDtl>();
        }

        public decimal CartId { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? RequestedShipdate { get; set; }
        public decimal? OrderId { get; set; }
        public decimal? ShipdayId { get; set; }
        public DateTime? ActualShipdate { get; set; }
        public decimal BoxingCharge { get; set; }
        public decimal SmallOrderCharge { get; set; }
        public decimal ServicesCharge { get; set; }
        public decimal ShippingCharge { get; set; }
        public decimal OrderSubtotal { get; set; }
        public decimal OrderTotal { get; set; }
        public string RequestShipEarly { get; set; }
        public string RequestPickup { get; set; }
        public string RequestContactPhone { get; set; }
        public string RequestContactEmail { get; set; }
        public string Comments { get; set; }
        public string PaymentMethod { get; set; }
        public string IpAddress { get; set; }
        public decimal? BillingId { get; set; }
        public decimal? ShippingId { get; set; }
        public decimal PpPaidAmount { get; set; }
        public string PpReference { get; set; }
        public decimal QuarterboxCharge { get; set; }
        public decimal AirmailCharge { get; set; }
        public decimal PostageCharge { get; set; }
        public string CcNumber { get; set; }
        public string CcExpMonth { get; set; }
        public string CcExpYear { get; set; }
        public string CcCvv { get; set; }

        public virtual Customer Billing { get; set; }
        public virtual ShipdayHdr Shipday { get; set; }
        public virtual Customer Shipping { get; set; }
        public virtual ICollection<CartDtl> CartDtl { get; set; }
    }
}
