using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class CustomerNote
    {
        public decimal CustomerNoteId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal NoteTypeId { get; set; }
        public string Note { get; set; }
        public decimal PersonId { get; set; }
        public DateTime DatetimeStamp { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Person Person { get; set; }
    }
}
