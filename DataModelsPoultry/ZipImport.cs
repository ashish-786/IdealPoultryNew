using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ZipImport
    {
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AreaCode { get; set; }
        public string StateFips { get; set; }
        public string CountyFips { get; set; }
        public string PlaceFips { get; set; }
        public string MsaCode { get; set; }
        public string TimeZone { get; set; }
        public string Dst { get; set; }
        public string ZipType { get; set; }
    }
}
