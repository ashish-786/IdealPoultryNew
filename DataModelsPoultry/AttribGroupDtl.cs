using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class AttribGroupDtl
    {
        public decimal AttribGroupDtlId { get; set; }
        public decimal AttribGroupHdrId { get; set; }
        public byte SortOrder { get; set; }
        public string AllowMultipleEntires { get; set; }
        public string PresentationType { get; set; }
        public decimal AttribHdrId { get; set; }
        public string IsRequired { get; set; }
        public string Orientation { get; set; }

        public virtual AttribGroupHdr AttribGroupHdr { get; set; }
        public virtual AttribHdr AttribHdr { get; set; }
    }
}
