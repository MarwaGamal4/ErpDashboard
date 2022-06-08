using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbTransctionsOtherAdd
    {
        public int Id { get; set; }
        public int? TransctionId { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? AddPercent { get; set; }
        public decimal? AddValue { get; set; }
        public string Notes { get; set; }

        public virtual TbTransactionHeader Transction { get; set; }
    }
}
