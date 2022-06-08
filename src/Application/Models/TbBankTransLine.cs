using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbBankTransLine
    {
        public int RestLineId { get; set; }
        public decimal? RestDebtor { get; set; }
        public decimal? RestCreditor { get; set; }
        public string RestAccNum { get; set; }
        public string RestAccName { get; set; }
        public string RestNote { get; set; }
        public int RestHdrId { get; set; }
        public decimal? CostValue { get; set; }
        public string CostParient { get; set; }
        public string CostChild { get; set; }
        public bool? CostFlag { get; set; }
        public bool? MainCost { get; set; }

        public virtual TbBankTransHdr RestHdr { get; set; }
    }
}
