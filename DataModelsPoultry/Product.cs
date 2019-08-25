using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Product
    {
        public Product()
        {
            Availability = new HashSet<Availability>();
            BoxDtl = new HashSet<BoxDtl>();
            BreedsearchDetail = new HashSet<BreedsearchDetail>();
            CartDtl = new HashSet<CartDtl>();
            DropshipDtl = new HashSet<DropshipDtl>();
            ProductBreakpoint = new HashSet<ProductBreakpoint>();
            ProductBreedProduct = new HashSet<ProductBreedProduct>();
            ProductSoldout = new HashSet<ProductSoldout>();
            SoldOut = new HashSet<SoldOut>();
            Specials = new HashSet<Specials>();
            SuborderDtl = new HashSet<SuborderDtl>();
            SuggestiveSell = new HashSet<SuggestiveSell>();
            Waitlist = new HashSet<Waitlist>();
            WebBlackout = new HashSet<WebBlackout>();
            WebItemProduct = new HashSet<WebItemProduct>();
            WebSoldout = new HashSet<WebSoldout>();
        }

        public decimal ProductId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ProductTypeId { get; set; }
        public decimal NumberToCorner { get; set; }
        public string PrintUnitAmount { get; set; }
        public string PrintOnLabel { get; set; }
        public string CheckAvailability { get; set; }
        public string BoldAvailability { get; set; }
        public decimal? ProductcolorId { get; set; }
        public decimal? EastercodeId { get; set; }
        public decimal? Pricepoint1 { get; set; }
        public decimal? Pricepoint2 { get; set; }
        public decimal? Pricepoint3 { get; set; }
        public string NpipCode { get; set; }
        public string Sku { get; set; }
        public decimal? SortOrder { get; set; }
        public string PrintOnAvailability { get; set; }
        public decimal? Pricepoint4 { get; set; }
        public string Inactive { get; set; }
        public decimal? Pricepoint5 { get; set; }
        public decimal? InventoryControlAmount { get; set; }
        public DateTime? InventoryControlDate { get; set; }
        public decimal? InventoryControlMinimum { get; set; }
        public decimal BreedId { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual Eastercode Eastercode { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Productcolor Productcolor { get; set; }
        public virtual ICollection<Availability> Availability { get; set; }
        public virtual ICollection<BoxDtl> BoxDtl { get; set; }
        public virtual ICollection<BreedsearchDetail> BreedsearchDetail { get; set; }
        public virtual ICollection<CartDtl> CartDtl { get; set; }
        public virtual ICollection<DropshipDtl> DropshipDtl { get; set; }
        public virtual ICollection<ProductBreakpoint> ProductBreakpoint { get; set; }
        public virtual ICollection<ProductBreedProduct> ProductBreedProduct { get; set; }
        public virtual ICollection<ProductSoldout> ProductSoldout { get; set; }
        public virtual ICollection<SoldOut> SoldOut { get; set; }
        public virtual ICollection<Specials> Specials { get; set; }
        public virtual ICollection<SuborderDtl> SuborderDtl { get; set; }
        public virtual ICollection<SuggestiveSell> SuggestiveSell { get; set; }
        public virtual ICollection<Waitlist> Waitlist { get; set; }
        public virtual ICollection<WebBlackout> WebBlackout { get; set; }
        public virtual ICollection<WebItemProduct> WebItemProduct { get; set; }
        public virtual ICollection<WebSoldout> WebSoldout { get; set; }
    }
}
