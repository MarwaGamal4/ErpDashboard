using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbItemsSection
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int? ItemId { get; set; }
        public int? MealId { get; set; }
        public string SelectedName { get; set; }
        public bool? Selected { get; set; }

        public virtual TbItem Item { get; set; }
        public virtual TbMeal Meal { get; set; }
        public virtual TbMenuSection Section { get; set; }
    }
}
