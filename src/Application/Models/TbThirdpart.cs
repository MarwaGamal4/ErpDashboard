using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbThirdpart
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public bool Status { get; set; }
    }
}
