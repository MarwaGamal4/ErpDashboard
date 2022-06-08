using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbInventoryDetail
    {
        public int Id { get; set; }
        public int InventoryDetailsId { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public int? UnitId { get; set; }
        public decimal? BookQty { get; set; }
        public decimal? ActualQty { get; set; }
        public decimal? Balance { get; set; }

        public virtual TbInventoryHeader InventoryDetails { get; set; }
    }
}
