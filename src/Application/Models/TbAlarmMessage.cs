using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbAlarmMessage
    {
        public int MsgId { get; set; }
        public string MsgText { get; set; }
        public DateTime? MsgDateFrom { get; set; }
        public DateTime? MsgDateTo { get; set; }
        public bool? MsgActive { get; set; }
        public int? ComId { get; set; }
    }
}
