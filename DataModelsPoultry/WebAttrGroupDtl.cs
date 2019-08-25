using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebAttrGroupDtl
    {
        public decimal WebAttrGroupDtlId { get; set; }
        public decimal WebAttrGroupId { get; set; }
        public byte SortOrder { get; set; }
        public string AllowMultipleEntires { get; set; }
        public string PresentationType { get; set; }
        public decimal WebAttrId { get; set; }
        public string IsRequired { get; set; }
        public string Orientation { get; set; }
        public decimal? IconImageNormal { get; set; }
        public decimal? IconImageSelected { get; set; }

        public virtual WebImage IconImageNormalNavigation { get; set; }
        public virtual WebImage IconImageSelectedNavigation { get; set; }
        public virtual WebAttr WebAttr { get; set; }
        public virtual WebAttrGroup WebAttrGroup { get; set; }
    }
}
