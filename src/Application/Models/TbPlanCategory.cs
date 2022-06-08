using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanCategory
    {
        public TbPlanCategory()
        {
            TbCustomPrices = new HashSet<TbCustomPrice>();
            TbMeals = new HashSet<TbMeal>();
            TbPlanCatTips = new HashSet<TbPlanCatTip>();
            TbPlanMasterHdrs = new HashSet<TbPlanMasterHdr>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public int ComId { get; set; }
        public int UserId { get; set; }
        public string Symbol { get; set; }
        public bool IsCustom { get; set; }

        public virtual ICollection<TbCustomPrice> TbCustomPrices { get; set; }
        public virtual ICollection<TbMeal> TbMeals { get; set; }
        public virtual ICollection<TbPlanCatTip> TbPlanCatTips { get; set; }
        public virtual ICollection<TbPlanMasterHdr> TbPlanMasterHdrs { get; set; }
    }
}
