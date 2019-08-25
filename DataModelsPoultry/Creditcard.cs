using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Creditcard
    {
        public string CreditcardType { get; set; }
        public string NumberFormat { get; set; }
        public string Description { get; set; }
        public string DisplayMask { get; set; }
    }
}
