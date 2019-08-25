using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebPreview
    {
        public decimal WebPreviewId { get; set; }
        public string Description { get; set; }
        public decimal LeftImageId { get; set; }
        public decimal? RightImageId { get; set; }
        public decimal WebItemId { get; set; }

        public virtual WebImage LeftImage { get; set; }
        public virtual WebImage RightImage { get; set; }
    }
}
