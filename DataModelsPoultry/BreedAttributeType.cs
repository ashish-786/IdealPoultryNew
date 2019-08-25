using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class BreedAttributeType
    {
        public BreedAttributeType()
        {
            BreedAttribute = new HashSet<BreedAttribute>();
        }

        public decimal BreedAttributeTypeId { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }
        public string ShowAsAttribute { get; set; }
        public string ShowAttributeName { get; set; }

        public virtual ICollection<BreedAttribute> BreedAttribute { get; set; }
    }
}
