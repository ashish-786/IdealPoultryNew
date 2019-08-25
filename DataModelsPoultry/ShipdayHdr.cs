using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ShipdayHdr
    {
        public ShipdayHdr()
        {
            CartHdr = new HashSet<CartHdr>();
            CustomerCalllist = new HashSet<CustomerCalllist>();
            DropshipDtl = new HashSet<DropshipDtl>();
            EasterDatesDate1 = new HashSet<EasterDates>();
            EasterDatesDate2 = new HashSet<EasterDates>();
            EasterDatesDate3 = new HashSet<EasterDates>();
            EasterDatesDate4 = new HashSet<EasterDates>();
            InversePreviousYear = new HashSet<ShipdayHdr>();
            OrderHdr = new HashSet<OrderHdr>();
            ShipdayDtl = new HashSet<ShipdayDtl>();
            WebBlackout = new HashSet<WebBlackout>();
            WebOrderHdr = new HashSet<WebOrderHdr>();
        }

        public decimal ShipdayId { get; set; }
        public DateTime ShipDate { get; set; }
        public string Notes { get; set; }
        public decimal OrderTypeId { get; set; }
        public string IsClosed { get; set; }
        public decimal? PreviousYearId { get; set; }

        public virtual OrderType OrderType { get; set; }
        public virtual ShipdayHdr PreviousYear { get; set; }
        public virtual ICollection<CartHdr> CartHdr { get; set; }
        public virtual ICollection<CustomerCalllist> CustomerCalllist { get; set; }
        public virtual ICollection<DropshipDtl> DropshipDtl { get; set; }
        public virtual ICollection<EasterDates> EasterDatesDate1 { get; set; }
        public virtual ICollection<EasterDates> EasterDatesDate2 { get; set; }
        public virtual ICollection<EasterDates> EasterDatesDate3 { get; set; }
        public virtual ICollection<EasterDates> EasterDatesDate4 { get; set; }
        public virtual ICollection<ShipdayHdr> InversePreviousYear { get; set; }
        public virtual ICollection<OrderHdr> OrderHdr { get; set; }
        public virtual ICollection<ShipdayDtl> ShipdayDtl { get; set; }
        public virtual ICollection<WebBlackout> WebBlackout { get; set; }
        public virtual ICollection<WebOrderHdr> WebOrderHdr { get; set; }
    }
}
