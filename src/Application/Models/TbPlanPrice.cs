using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanPrice
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int CategeoryTypeId { get; set; }
        public int PlanDayId { get; set; }
        public int CategoryCount { get; set; }
        public int MealTypeId { get; set; }
        public int DayCount { get; set; }
        public decimal Amount { get; set; }

        public virtual TbMealsCategory CategeoryType { get; set; }
        public virtual TbPlanMasterHdr Plan { get; set; }
        public virtual TbPlanDay PlanDay { get; set; }
    }
}
