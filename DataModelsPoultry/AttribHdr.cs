using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class AttribHdr
    {
        public AttribHdr()
        {
            AttribGroupDtl = new HashSet<AttribGroupDtl>();
        }

        public decimal AttribHdrId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string EditPrompt { get; set; }

        public virtual ICollection<AttribGroupDtl> AttribGroupDtl { get; set; }
    }
}
