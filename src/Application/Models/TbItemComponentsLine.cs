using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbItemComponentsLine
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public int IsUnit123 { get; set; }
        public string UnitName { get; set; }
        public bool? PriceEntered { get; set; }
        public string PriceType { get; set; }
        public decimal Qty { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal Total { get; set; }
        public int ItemComHdr { get; set; }
        public int ItemType { get; set; }

        public virtual TbItemComponentsHdr ItemComHdrNavigation { get; set; }
    }
}
