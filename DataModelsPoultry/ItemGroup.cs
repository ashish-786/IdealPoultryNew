using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ItemGroup
    {
        public ItemGroup()
        {
            ItemGroupProductClass = new HashSet<ItemGroupProductClass>();
        }

        public decimal ItemGroupId { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }

        public virtual ICollection<ItemGroupProductClass> ItemGroupProductClass { get; set; }
    }
}
