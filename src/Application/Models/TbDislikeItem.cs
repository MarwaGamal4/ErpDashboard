using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDislikeItem
    {
        public int Id { get; set; }
        public int DislikeCategoryId { get; set; }
        public int OppositeItemId { get; set; }
        public int? Qty { get; set; }
        public int? OppositeQty { get; set; }
        public int ItemUnit { get; set; }
        public int? OpsiteItemUnit { get; set; }
        public int? ForEashQtyUnit { get; set; }
        public int? OppositeForEashQtyUnit { get; set; }
        public bool IsOppositeItemRelated { get; set; }
        public int ComId { get; set; }
        public int ItemId { get; set; }
        public int ReplacPloicy { get; set; }

        public virtual TbDislikeCategory DislikeCategory { get; set; }
    }
}
