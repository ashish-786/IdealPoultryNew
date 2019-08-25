using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class TempLob
    {
        public Guid TempLobId { get; set; }
        public string ClobVal { get; set; }
        public byte[] BlobVal { get; set; }
    }
}
