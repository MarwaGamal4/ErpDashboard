using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbOpeningEntryHeader
    {
        public TbOpeningEntryHeader()
        {
            TbOpeningEntryDetails = new HashSet<TbOpeningEntryDetail>();
        }

        public int Id { get; set; }
        public int? EntryNo { get; set; }
        public DateTime? Entrydate { get; set; }
        public int? EntryCurrancy { get; set; }
        public decimal? CurrancyPrice { get; set; }
        public string EntryType { get; set; }
        public string EntryNotes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public int? PeriodId { get; set; }
        public int? RestId { get; set; }

        public virtual ICollection<TbOpeningEntryDetail> TbOpeningEntryDetails { get; set; }
    }
}
