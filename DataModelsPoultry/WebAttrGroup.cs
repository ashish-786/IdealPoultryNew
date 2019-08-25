using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAttrGroup
    {
        public WebAttrGroup()
        {
            WebAttrGroupDtl = new HashSet<WebAttrGroupDtl>();
            WebItem = new HashSet<WebItem>();
        }

        public decimal WebAttrGroupId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WebAttrGroupDtl> WebAttrGroupDtl { get; set; }
        public virtual ICollection<WebItem> WebItem { get; set; }
    }
}
