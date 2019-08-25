using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomAvailMaster
    {
        public CustomAvailMaster()
        {
            CustomAvailDetail = new HashSet<CustomAvailDetail>();
        }

        public decimal CustomAvailId { get; set; }
        public string Description { get; set; }
        public byte ReportType { get; set; }

        public virtual ICollection<CustomAvailDetail> CustomAvailDetail { get; set; }
    }
}
