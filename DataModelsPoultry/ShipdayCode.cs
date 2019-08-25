using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ShipdayCode
    {
        public ShipdayCode()
        {
            Breed = new HashSet<Breed>();
            ShipdayDtl = new HashSet<ShipdayDtl>();
        }

        public decimal ShipdayCodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string IsEaster { get; set; }

        public virtual ICollection<Breed> Breed { get; set; }
        public virtual ICollection<ShipdayDtl> ShipdayDtl { get; set; }
    }
}
