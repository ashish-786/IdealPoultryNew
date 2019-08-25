using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class AttribGroupHdr
    {
        public AttribGroupHdr()
        {
            AttribGroupDtl = new HashSet<AttribGroupDtl>();
            Breed = new HashSet<Breed>();
        }

        public decimal AttribGroupHdrId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AttribGroupDtl> AttribGroupDtl { get; set; }
        public virtual ICollection<Breed> Breed { get; set; }
    }
}
