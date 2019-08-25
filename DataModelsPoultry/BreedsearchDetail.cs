using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedsearchDetail
    {
        public decimal BreedsearchId { get; set; }
        public decimal ProductId { get; set; }
        public decimal BreedsearchDetailId { get; set; }

        public virtual BreedsearchMaster Breedsearch { get; set; }
        public virtual Product Product { get; set; }
    }
}
