using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebFaq
    {
        public decimal WebFaqId { get; set; }
        public decimal Sequencing { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
