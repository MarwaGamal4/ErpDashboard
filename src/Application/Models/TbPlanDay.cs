using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanDay
    {
        public TbPlanDay()
        {
            TbPlanPrices = new HashSet<TbPlanPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DayCount { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<TbPlanPrice> TbPlanPrices { get; set; }
    }
}
