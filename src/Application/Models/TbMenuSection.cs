using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMenuSection
    {
        public TbMenuSection()
        {
            TbItems = new HashSet<TbItem>();
            TbItemsSections = new HashSet<TbItemsSection>();
            TbMeals = new HashSet<TbMeal>();
        }

        public int Id { get; set; }
        public int? SectionId { get; set; }
        public string EnName { get; set; }
        public string Notes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<TbItem> TbItems { get; set; }
        public virtual ICollection<TbItemsSection> TbItemsSections { get; set; }
        public virtual ICollection<TbMeal> TbMeals { get; set; }
    }
}
