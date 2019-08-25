using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Sessions
    {
        public string Id { get; set; }
        public string ASession { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
