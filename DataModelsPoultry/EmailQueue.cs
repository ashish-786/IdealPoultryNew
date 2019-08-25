using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EmailQueue
    {
        public EmailQueue()
        {
            EmailQueueVars = new HashSet<EmailQueueVars>();
        }

        public decimal EmailQueueId { get; set; }
        public string EmailAddress { get; set; }
        public string EmailTemplateName { get; set; }
        public string RealName { get; set; }
        public DateTime? AttemptDate { get; set; }
        public string Error { get; set; }
        public string Subject { get; set; }
        public decimal InstanceNumber { get; set; }

        public virtual EmailTemplate EmailTemplateNameNavigation { get; set; }
        public virtual ICollection<EmailQueueVars> EmailQueueVars { get; set; }
    }
}
