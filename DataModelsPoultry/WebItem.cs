using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebItem
    {
        public WebItem()
        {
            WebBreedItem = new HashSet<WebBreedItem>();
            WebItemDescription = new HashSet<WebItemDescription>();
            WebItemProduct = new HashSet<WebItemProduct>();
            WebSearch = new HashSet<WebSearch>();
            WebSeason = new HashSet<WebSeason>();
        }

        public decimal WebItemId { get; set; }
        public decimal LeftWebImageId { get; set; }
        public decimal? RightWebImageId { get; set; }
        public string Description { get; set; }
        public string ShowOnWeb { get; set; }
        public decimal? WebAttrGroupId { get; set; }

        public virtual WebImage LeftWebImage { get; set; }
        public virtual WebImage RightWebImage { get; set; }
        public virtual WebAttrGroup WebAttrGroup { get; set; }
        public virtual ICollection<WebBreedItem> WebBreedItem { get; set; }
        public virtual ICollection<WebItemDescription> WebItemDescription { get; set; }
        public virtual ICollection<WebItemProduct> WebItemProduct { get; set; }
        public virtual ICollection<WebSearch> WebSearch { get; set; }
        public virtual ICollection<WebSeason> WebSeason { get; set; }
    }
}
