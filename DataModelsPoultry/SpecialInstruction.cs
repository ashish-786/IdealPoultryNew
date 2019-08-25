using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class SpecialInstruction
    {
        public decimal SpecialInstructionId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DoNotChargeForBoxing { get; set; }
        public string IsHealthPapers { get; set; }
        public string MustShip { get; set; }
        public decimal? SortOrder { get; set; }
    }
}
