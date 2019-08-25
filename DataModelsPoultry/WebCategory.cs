using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebCategory
    {
        public WebCategory()
        {
            WebCategoryBreed = new HashSet<WebCategoryBreed>();
        }

        public decimal WebCategoryId { get; set; }
        public string Description { get; set; }
        public decimal SortOrder { get; set; }
        public decimal WebImageId { get; set; }
        public string ShortName { get; set; }
        public decimal RealAvailabilityWindow { get; set; }
        public decimal PricesheetId { get; set; }

        public virtual Pricesheet Pricesheet { get; set; }
        public virtual WebImage WebImage { get; set; }
        public virtual ICollection<WebCategoryBreed> WebCategoryBreed { get; set; }
    }
}
