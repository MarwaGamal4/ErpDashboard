using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbOpeningEntryDetail
    {
        public int Id { get; set; }
        public int? DetialsId { get; set; }
        public string AccountNo { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string DetialsNotes { get; set; }
        public string AccountName { get; set; }
        public int? ColRel { get; set; }

        public virtual TbOpeningEntryHeader Detials { get; set; }
    }
}
