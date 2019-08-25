using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Rolodex
    {
        public decimal RolodexId { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public decimal? ZipcodeId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Contact { get; set; }
        public decimal RolodexTypeId { get; set; }
        public string AlphaSearch { get; set; }
        public string Notes { get; set; }
        public string QuickDialNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
