using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebSearch
    {
        public decimal WebSearchId { get; set; }
        public string Url { get; set; }
        public decimal? WebItemId { get; set; }
        public string DefaultPageTitle { get; set; }

        public virtual WebItem WebItem { get; set; }
    }
}
