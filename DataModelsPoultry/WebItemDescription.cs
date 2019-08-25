using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebItemDescription
    {
        public decimal WebItemDescriptionId { get; set; }
        public decimal WebItemId { get; set; }
        public decimal Sequence { get; set; }
        public decimal Flags { get; set; }
        public string Text { get; set; }

        public virtual WebItem WebItem { get; set; }
    }
}
