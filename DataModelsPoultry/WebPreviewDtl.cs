using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class WebPreviewDtl
    {
        public decimal WebPreviewId { get; set; }
        public decimal SortOrder { get; set; }
        public decimal Flags { get; set; }
        public string HtmlText { get; set; }
    }
}
