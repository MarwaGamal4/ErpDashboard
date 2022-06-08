using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPivotetable
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string Month { get; set; }
        public decimal? Total { get; set; }
        public int? MonthNumber { get; set; }
    }
}
