using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebSeason
    {
        public decimal WebSeasonId { get; set; }
        public decimal WebItemId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual WebItem WebItem { get; set; }
    }
}
