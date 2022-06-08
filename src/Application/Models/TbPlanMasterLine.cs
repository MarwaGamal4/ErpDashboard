using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanMasterLine
    {
        public int Id { get; set; }
        public int Days { get; set; }
        public string DaysNames { get; set; }
        public string MealName { get; set; }
        public int MealId { get; set; }
        public string TypeName { get; set; }
        public int TypeId { get; set; }
        public decimal MealCost { get; set; }
        public decimal MealPrice { get; set; }
        public int HdrId { get; set; }

        public virtual TbPlanMasterHdr Hdr { get; set; }
        public virtual TbMeal Meal { get; set; }
        public virtual TbMealsType Type { get; set; }
    }
}
