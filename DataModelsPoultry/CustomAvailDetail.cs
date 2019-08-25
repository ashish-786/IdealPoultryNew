using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomAvailDetail
    {
        public decimal CustomAvailId { get; set; }
        public decimal CustomAvailDetailId { get; set; }
        public decimal BreedId { get; set; }

        public virtual Breed Breed { get; set; }
        public virtual CustomAvailMaster CustomAvail { get; set; }
    }
}
