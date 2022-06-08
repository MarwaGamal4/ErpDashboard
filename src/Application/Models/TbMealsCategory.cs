using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMealsCategory
    {
        public TbMealsCategory()
        {
            TbCustomPrices = new HashSet<TbCustomPrice>();
            TbMealsTypes = new HashSet<TbMealsType>();
            TbPlanPrices = new HashSet<TbPlanPrice>();
        }

        public int Id { get; set; }
        public int? MealCategoryId { get; set; }
        public string EnName { get; set; }
        public string Notes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public string Symbol { get; set; }
        public bool Issnack { get; set; }

        public virtual ICollection<TbCustomPrice> TbCustomPrices { get; set; }
        public virtual ICollection<TbMealsType> TbMealsTypes { get; set; }
        public virtual ICollection<TbPlanPrice> TbPlanPrices { get; set; }
    }
}
