using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAttr
    {
        public WebAttr()
        {
            WebAttrDtl = new HashSet<WebAttrDtl>();
            WebAttrGroupDtl = new HashSet<WebAttrGroupDtl>();
        }

        public decimal WebAttrId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string EditPrompt { get; set; }

        public virtual ICollection<WebAttrDtl> WebAttrDtl { get; set; }
        public virtual ICollection<WebAttrGroupDtl> WebAttrGroupDtl { get; set; }
    }
}
