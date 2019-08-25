using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class EdiTranslation
    {
        public decimal EdiTranslationId { get; set; }
        public decimal EdiPartnerId { get; set; }
        public string TableName { get; set; }
        public string PartnerValue { get; set; }
        public string InternalValue { get; set; }

        public virtual EdiPartner EdiPartner { get; set; }
    }
}
