using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EmailQueueVars
    {
        public decimal EmailQueueVarsId { get; set; }
        public decimal EmailQueueId { get; set; }
        public string Variable { get; set; }
        public string Value { get; set; }
        public decimal Instance { get; set; }

        public virtual EmailQueue EmailQueue { get; set; }
    }
}
