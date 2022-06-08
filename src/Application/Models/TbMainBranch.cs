using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMainBranch
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string OtherAccount { get; set; }
        public string Notes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public string MainAccount { get; set; }
        public string Costnumber { get; set; }
        public string CashNumber { get; set; }
    }
}
