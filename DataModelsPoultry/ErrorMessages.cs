using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class ErrorMessages
    {
        public string ConstraintName { get; set; }
        public string Actions { get; set; }
        public string ParentChild { get; set; }
        public string ErrorMessage { get; set; }
    }
}
