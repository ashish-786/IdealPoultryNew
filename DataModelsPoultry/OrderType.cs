using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class OrderType
    {
        public OrderType()
        {
            PostalWeight = new HashSet<PostalWeight>();
            ShipdayHdr = new HashSet<ShipdayHdr>();
        }

        public decimal OrderTypeId { get; set; }
        public string Description { get; set; }
        public decimal BoxesToCodBundle { get; set; }
        public string Classification { get; set; }
        public string IsDefault { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<PostalWeight> PostalWeight { get; set; }
        public virtual ICollection<ShipdayHdr> ShipdayHdr { get; set; }
    }
}
