using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebSpecialService
    {
        public decimal WebSpecialServiceId { get; set; }
        public decimal SpecialServiceId { get; set; }
        public string AltDescription { get; set; }

        public virtual SpecialService SpecialService { get; set; }
    }
}
