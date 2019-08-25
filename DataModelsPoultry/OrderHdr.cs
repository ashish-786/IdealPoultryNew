using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class OrderHdr
    {
        public OrderHdr()
        {
            ActivityDtl = new HashSet<ActivityDtl>();
            CodCard = new HashSet<CodCard>();
            MemoHdr = new HashSet<MemoHdr>();
            Suborder = new HashSet<Suborder>();
            WebOrderMaster = new HashSet<WebOrderMaster>();
        }

        public decimal OrderId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal BillingId { get; set; }
        public decimal ShipdayId { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime DateChanged { get; set; }
        public string ChargeForCod { get; set; }
        public string ChargeForPostage { get; set; }
        public string ChargeForInsurance { get; set; }
        public string ToBeDelivered { get; set; }
        public string ToBePickedUp { get; set; }
        public string PrintCodReport { get; set; }
        public string PrintInvoice { get; set; }
        public decimal DiscountPercent { get; set; }
        public string PostedToAccounting { get; set; }
        public string IsCodInvoice { get; set; }
        public string IsCreditcardInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? MultipleOrderId { get; set; }
        public string McmurryOrderId { get; set; }
        public string Code { get; set; }
        public string ChargeForSmallOrder { get; set; }
        public string ChargeForQuarterBox { get; set; }
        public decimal ShippingHatcheryId { get; set; }
        public decimal? InvoicePrintCount { get; set; }
        public string ShouldLabelsPrint { get; set; }
        public string Notes { get; set; }
        public string PrintCodCard { get; set; }
        public decimal? PlacedbyId { get; set; }
        public string Notes2 { get; set; }
        public decimal EdiStatus { get; set; }
        public string CanMoveUp { get; set; }
        public string PlacedbyContact { get; set; }
        public decimal? CustomerCreditcardId { get; set; }
        public decimal QuarterboxAmount { get; set; }
        public decimal SmallorderAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal CodAmount { get; set; }
        public decimal CodOverrideAmount { get; set; }
        public decimal PostageAmount { get; set; }
        public decimal ServicesAmount { get; set; }
        public decimal ItemSubtotalAmount { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal BoxingAmount { get; set; }
        public decimal AirmailAmount { get; set; }
        public decimal PostageOverrideAmount { get; set; }
        public decimal AirmailOverrideAmount { get; set; }
        public decimal? EdiPartnerId { get; set; }
        public string EdiPartnerLocator { get; set; }

        public virtual Customer Billing { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerCreditcard CustomerCreditcard { get; set; }
        public virtual EdiPartner EdiPartner { get; set; }
        public virtual ShipdayHdr Shipday { get; set; }
        public virtual Hatchery ShippingHatchery { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual ICollection<ActivityDtl> ActivityDtl { get; set; }
        public virtual ICollection<CodCard> CodCard { get; set; }
        public virtual ICollection<MemoHdr> MemoHdr { get; set; }
        public virtual ICollection<Suborder> Suborder { get; set; }
        public virtual ICollection<WebOrderMaster> WebOrderMaster { get; set; }
    }
}
