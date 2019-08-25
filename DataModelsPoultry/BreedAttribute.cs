using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedAttribute
    {
        public BreedAttribute()
        {
            BreedAttributeDtl = new HashSet<BreedAttributeDtl>();
        }

        public decimal BreedAttributeId { get; set; }
        public decimal BreedAttributeTypeId { get; set; }
        public string Value { get; set; }
        public byte SortOrder { get; set; }

        public virtual BreedAttributeType BreedAttributeType { get; set; }
        public virtual ICollection<BreedAttributeDtl> BreedAttributeDtl { get; set; }
    }
}
