using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebImage
    {
        public WebImage()
        {
            WebAttrGroupDtlIconImageNormalNavigation = new HashSet<WebAttrGroupDtl>();
            WebAttrGroupDtlIconImageSelectedNavigation = new HashSet<WebAttrGroupDtl>();
            WebCategory = new HashSet<WebCategory>();
            WebItemLeftWebImage = new HashSet<WebItem>();
            WebItemRightWebImage = new HashSet<WebItem>();
            WebPreviewLeftImage = new HashSet<WebPreview>();
            WebPreviewRightImage = new HashSet<WebPreview>();
        }

        public decimal WebImageId { get; set; }
        public string Description { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string Src { get; set; }
        public string ImgType { get; set; }
        public string Etag { get; set; }
        public byte[] ImgData { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<WebAttrGroupDtl> WebAttrGroupDtlIconImageNormalNavigation { get; set; }
        public virtual ICollection<WebAttrGroupDtl> WebAttrGroupDtlIconImageSelectedNavigation { get; set; }
        public virtual ICollection<WebCategory> WebCategory { get; set; }
        public virtual ICollection<WebItem> WebItemLeftWebImage { get; set; }
        public virtual ICollection<WebItem> WebItemRightWebImage { get; set; }
        public virtual ICollection<WebPreview> WebPreviewLeftImage { get; set; }
        public virtual ICollection<WebPreview> WebPreviewRightImage { get; set; }
    }
}
