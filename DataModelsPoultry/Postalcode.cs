using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Postalcode
    {
        public Postalcode()
        {
            Breed = new HashSet<Breed>();
            HundredPricing = new HashSet<HundredPricing>();
            PostalcodeCharge = new HashSet<PostalcodeCharge>();
        }

        public decimal PostalcodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal AirChargeAmount { get; set; }
        public decimal PerUnitWeight { get; set; }

        public virtual ICollection<Breed> Breed { get; set; }
        public virtual ICollection<HundredPricing> HundredPricing { get; set; }
        public virtual ICollection<PostalcodeCharge> PostalcodeCharge { get; set; }
    }
}
