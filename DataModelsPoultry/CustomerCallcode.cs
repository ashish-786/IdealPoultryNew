using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerCallcode
    {
        public decimal CustomerId { get; set; }
        public decimal? PurchaseVolume { get; set; }
        public decimal? CustomerType { get; set; }
        public decimal? SeasonsOfPurchase { get; set; }
        public decimal? CallListCode { get; set; }
        public decimal? PrimarySupplier { get; set; }
        public decimal? SecondarySupplier { get; set; }
        public string Turkeys { get; set; }
        public string Ducks { get; set; }
        public string Mallards { get; set; }
        public string Geese { get; set; }
        public string Guineas { get; set; }
        public string Crested { get; set; }
        public string Bantams { get; set; }
        public string Silkies { get; set; }
        public string RbMeat { get; set; }
        public string Cornish { get; set; }
        public string Banner { get; set; }
        public string Sign { get; set; }
        public string StandardNotebook { get; set; }
        public string BantamNotebook { get; set; }
        public string DuckNotebook { get; set; }
        public string StartTime { get; set; }
        public string BusinessPics { get; set; }
        public decimal? ContactPics { get; set; }
        public string Book { get; set; }
        public decimal? Page { get; set; }
        public decimal? Feeddealer1 { get; set; }
        public decimal? Feeddealer2 { get; set; }

        public virtual CalllistCode ContactPicsNavigation { get; set; }
        public virtual CalllistCode CustomerTypeNavigation { get; set; }
        public virtual CalllistCode PrimarySupplierNavigation { get; set; }
        public virtual CalllistCode PurchaseVolumeNavigation { get; set; }
        public virtual CalllistCode SeasonsOfPurchaseNavigation { get; set; }
        public virtual CalllistCode SecondarySupplierNavigation { get; set; }
    }
}
