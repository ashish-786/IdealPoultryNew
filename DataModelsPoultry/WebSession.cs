using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebSession
    {
        public Guid Sessionid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string FromIp { get; set; }
        public string Data { get; set; }
    }
}
