using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbAccount
    {
        public int Id { get; set; }
        public string AccNumber { get; set; }
        public string AccParentid { get; set; }
        public string AccArName { get; set; }
        public string AccEnName { get; set; }
        public int? AccLevelNo { get; set; }
        public bool? AccAccept { get; set; }
        public string AccAcType { get; set; }
        public bool? Active { get; set; }
        public bool? HasCost { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Related { get; set; }
        public bool? Selected { get; set; }
        public int? SortId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? MoveCount { get; set; }
        public decimal? AccountBalance { get; set; }
        public decimal? LastDebit { get; set; }
        public decimal? LastCredit { get; set; }
        public decimal? AccountBalanceCredit { get; set; }
        public string RelatedScreen { get; set; }
    }
}
