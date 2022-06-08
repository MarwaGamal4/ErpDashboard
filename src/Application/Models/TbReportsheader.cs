using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbReportsheader
    {
        public TbReportsheader()
        {
            TbReportdetails = new HashSet<TbReportdetail>();
        }

        public int Id { get; set; }
        public string ReportName { get; set; }
        public string EntryType { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Notes { get; set; }
        public int? CurrancyIndex { get; set; }
        public int? CurrancyId { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<TbReportdetail> TbReportdetails { get; set; }
    }
}
