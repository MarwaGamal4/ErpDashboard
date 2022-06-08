using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbLoyaltyPoint
    {
        public int Id { get; set; }
        public int PointsId { get; set; }
        public decimal RelatedMoney { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
        public int Points { get; set; }
        public int ExpireRate { get; set; }
        public string ExpireCriteria { get; set; }
    }
}
