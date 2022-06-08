using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPayTypeLine
    {
        public int Id { get; set; }
        public int PaymethodId { get; set; }
        public int BranchId { get; set; }

        public virtual TbPayTypeHeader Paymethod { get; set; }
    }
}
