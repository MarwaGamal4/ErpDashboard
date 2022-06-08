using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanCatTip
    {
        public int Id { get; set; }
        public string TipText { get; set; }
        public int PlanCatId { get; set; }
        public int Pointer { get; set; }

        public virtual TbPlanCategory PlanCat { get; set; }
    }
}
