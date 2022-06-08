using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMealsNutiration
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public double Value { get; set; }
        public string Equation { get; set; }
        public string PercEquation { get; set; }
        public int Masterid { get; set; }
        public double NutPerc { get; set; }
        public string NutMasterName { get; set; }
        public bool CalcRow { get; set; }
        public int ComId { get; set; }

        public virtual TbMeal Meal { get; set; }
    }
}
