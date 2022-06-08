using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPeriodCloseHr
    {
        public TbPeriodCloseHr()
        {
            TbPeriodclodeDts = new HashSet<TbPeriodclodeDt>();
        }

        public int Id { get; set; }
        public int? CloseId { get; set; }
        public string CloseName { get; set; }
        public string CloseNotes { get; set; }
        public DateTime? CloseFrom { get; set; }
        public DateTime? CloseTo { get; set; }
        public int? ComId { get; set; }

        public virtual ICollection<TbPeriodclodeDt> TbPeriodclodeDts { get; set; }
    }
}
