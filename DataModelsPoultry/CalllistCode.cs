using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CalllistCode
    {
        public CalllistCode()
        {
            CustomerCallcodeContactPicsNavigation = new HashSet<CustomerCallcode>();
            CustomerCallcodeCustomerTypeNavigation = new HashSet<CustomerCallcode>();
            CustomerCallcodePrimarySupplierNavigation = new HashSet<CustomerCallcode>();
            CustomerCallcodePurchaseVolumeNavigation = new HashSet<CustomerCallcode>();
            CustomerCallcodeSeasonsOfPurchaseNavigation = new HashSet<CustomerCallcode>();
            CustomerCallcodeSecondarySupplierNavigation = new HashSet<CustomerCallcode>();
        }

        public decimal CalllistCodeId { get; set; }
        public string Description { get; set; }
        public string CustomercodeType { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CustomerCallcode> CustomerCallcodeContactPicsNavigation { get; set; }
        public virtual ICollection<CustomerCallcode> CustomerCallcodeCustomerTypeNavigation { get; set; }
        public virtual ICollection<CustomerCallcode> CustomerCallcodePrimarySupplierNavigation { get; set; }
        public virtual ICollection<CustomerCallcode> CustomerCallcodePurchaseVolumeNavigation { get; set; }
        public virtual ICollection<CustomerCallcode> CustomerCallcodeSeasonsOfPurchaseNavigation { get; set; }
        public virtual ICollection<CustomerCallcode> CustomerCallcodeSecondarySupplierNavigation { get; set; }
    }
}
