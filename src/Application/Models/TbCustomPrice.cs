using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustomPrice
    {
        public int Id { get; set; }
        public int MainCategoryId { get; set; }
        public int SupCategoryId { get; set; }
        public decimal Price { get; set; }
        public decimal? MaxQtyGm { get; set; }
        public decimal? MaxQtyPc { get; set; }
        public int CommId { get; set; }
        public int Count { get; set; }

        public virtual TbPlanCategory MainCategory { get; set; }
        public virtual TbMealsCategory SupCategory { get; set; }
    }
}
