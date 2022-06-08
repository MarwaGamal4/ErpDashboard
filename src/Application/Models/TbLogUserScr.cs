using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbLogUserScr
    {
        public int Id { get; set; }
        public int? ScrId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Datetime { get; set; }
        public bool? Added { get; set; }
        public bool? Modified { get; set; }
        public bool? Deleted { get; set; }
        public int? MasterId { get; set; }
        public int? ComId { get; set; }

        public virtual TbScreen Scr { get; set; }
        public virtual TbUser User { get; set; }
    }
}
