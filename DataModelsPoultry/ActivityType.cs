using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activity = new HashSet<Activity>();
            MemoStatus = new HashSet<MemoStatus>();
        }

        public decimal ActivityTypeId { get; set; }
        public string Description { get; set; }
        public string EntryType { get; set; }
        public string PostToCurrentActivity { get; set; }
        public string IsCodInvoice { get; set; }
        public string IsCreditCardInvoice { get; set; }
        public string IsStandardInvoice { get; set; }
        public string IsMemo { get; set; }
        public string IsFinanceCharge { get; set; }
        public string Code { get; set; }
        public string MenuPrompt { get; set; }
        public decimal? MenuOrder { get; set; }
        public string IsInvoice { get; set; }
        public string IsCreditCardPayment { get; set; }
        public string IsCreditCardRefund { get; set; }
        public string IsCreditCardAuthorization { get; set; }
        public string PrintReceipt { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<MemoStatus> MemoStatus { get; set; }
    }
}
