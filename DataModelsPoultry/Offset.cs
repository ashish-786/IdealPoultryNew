using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Offset
    {
        public Offset()
        {
            Breed = new HashSet<Breed>();
            SpecialService = new HashSet<SpecialService>();
        }

        public decimal OffsetId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal OffsetcodeId { get; set; }
        public string IsCod { get; set; }
        public string IsInsurance { get; set; }
        public string IsDiscount { get; set; }
        public string IsPostage { get; set; }
        public string IsQuarterbox { get; set; }
        public string IsSmallorder { get; set; }
        public string IsService { get; set; }

        public virtual Offsetcode Offsetcode { get; set; }
        public virtual ICollection<Breed> Breed { get; set; }
        public virtual ICollection<SpecialService> SpecialService { get; set; }
    }
}
