using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbManyCatMeal
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public int MealId { get; set; }

        public virtual TbMeal Meal { get; set; }
    }
}
