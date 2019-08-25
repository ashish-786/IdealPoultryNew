using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EmailTemplate
    {
        public EmailTemplate()
        {
            EmailQueue = new HashSet<EmailQueue>();
            EmailTemplateArg = new HashSet<EmailTemplateArg>();
        }

        public decimal EmailTemplateId { get; set; }
        public string Name { get; set; }
        public string Html { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<EmailTemplateArg> EmailTemplateArg { get; set; }
    }
}
