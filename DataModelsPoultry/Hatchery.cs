using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class Hatchery
    {
        public Hatchery()
        {
            Customer = new HashSet<Customer>();
            Customertype = new HashSet<Customertype>();
            EdiPartner = new HashSet<EdiPartner>();
            OrderHdr = new HashSet<OrderHdr>();
        }

        public decimal HatcheryId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal? ZipcodeId { get; set; }
        public string Telephone { get; set; }
        public string TollfreeTelephone { get; set; }
        public string NpipId { get; set; }
        public string Inactive { get; set; }

        public virtual Zipcode Zipcode { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Customertype> Customertype { get; set; }
        public virtual ICollection<EdiPartner> EdiPartner { get; set; }
        public virtual ICollection<OrderHdr> OrderHdr { get; set; }
    }
}
