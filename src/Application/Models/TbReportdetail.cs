using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbReportdetail
    {
        public int Id { get; set; }
        public int? RepordId { get; set; }
        public int? RowNo { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Formula { get; set; }
        public decimal? AccountBalance { get; set; }
        public bool? Bold { get; set; }
        public bool? UnderLine { get; set; }
        public bool? BackColor { get; set; }
        public int? OtherReport { get; set; }
        public int? ReportRow { get; set; }
        public bool? Visable { get; set; }

        public virtual TbReportsheader Repord { get; set; }
    }
}
