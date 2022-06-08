using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCosttreestructure
    {
        public int Id { get; set; }
        public int? StComId { get; set; }
        public string StArName { get; set; }
        public string StEnName { get; set; }
        public int? StLength { get; set; }
        public string StStartwith { get; set; }
        public string StCount { get; set; }
        public int? UserId { get; set; }
        public int? StId { get; set; }
    }
}
