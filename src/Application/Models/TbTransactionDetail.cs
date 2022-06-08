using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbTransactionDetail
    {
        public int Id { get; set; }
        public int? TransDetailId { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? TotalAfterDiscount { get; set; }
        public decimal? AddValuePercent { get; set; }
        public decimal? AddValueValue { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal? UnitRate { get; set; }
        public int? UnitPosition { get; set; }
        public string Unit1 { get; set; }
        public decimal? Unit2 { get; set; }
        public decimal? Unit3 { get; set; }
        public bool? Show { get; set; }
        public int? IsUnit123 { get; set; }
        public string Notes { get; set; }

        public virtual TbItem Item { get; set; }
        public virtual TbTransactionHeader TransDetail { get; set; }
    }
}
