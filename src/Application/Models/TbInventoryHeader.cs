using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbInventoryHeader
    {
        public TbInventoryHeader()
        {
            TbInventoryDetails = new HashSet<TbInventoryDetail>();
        }

        public int Id { get; set; }
        public int? InventoryId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public string InventoryNotes { get; set; }
        public DateTime? InventoryDate { get; set; }
        public int? StoreId { get; set; }

        public virtual ICollection<TbInventoryDetail> TbInventoryDetails { get; set; }
    }
}
