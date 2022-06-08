using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCostaccount
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
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Related { get; set; }
    }
}
