using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Hatchsessions
    {
        public string SessionId { get; set; }
        public decimal PersonId { get; set; }
        public DateTime ConnectDate { get; set; }
        public string Machine { get; set; }
    }
}
