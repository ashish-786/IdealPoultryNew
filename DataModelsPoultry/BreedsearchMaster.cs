using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedsearchMaster
    {
        public BreedsearchMaster()
        {
            BreedsearchDetail = new HashSet<BreedsearchDetail>();
        }

        public decimal BreedsearchId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BreedsearchDetail> BreedsearchDetail { get; set; }
    }
}
