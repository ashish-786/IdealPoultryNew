using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ActivitySession
    {
        public ActivitySession()
        {
            Activity = new HashSet<Activity>();
        }

        public decimal ActivitySessionId { get; set; }
        public string Description { get; set; }
        public decimal PersonId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string SessionType { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
    }
}
