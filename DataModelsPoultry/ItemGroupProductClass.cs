using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ItemGroupProductClass
    {
        public decimal ItemGroupId { get; set; }
        public decimal ProductClassId { get; set; }
        public byte SortOrder { get; set; }

        public virtual ItemGroup ItemGroup { get; set; }
        public virtual ProductClass ProductClass { get; set; }
    }
}
