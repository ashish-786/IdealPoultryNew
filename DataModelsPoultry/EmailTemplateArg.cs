using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EmailTemplateArg
    {
        public decimal EmailTemplateArgId { get; set; }
        public decimal EmailTemplateId { get; set; }
        public string TemplateVersion { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Required { get; set; }
        public string Datatype { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
    }
}
