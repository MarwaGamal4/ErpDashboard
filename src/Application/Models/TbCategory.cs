using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbItems = new HashSet<TbItem>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string EnName { get; set; }
        public string Notes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<TbItem> TbItems { get; set; }
    }
}
