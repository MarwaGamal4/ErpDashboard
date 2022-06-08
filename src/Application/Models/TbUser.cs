using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbUser
    {
        public TbUser()
        {
            TbLogUserScrs = new HashSet<TbLogUserScr>();
            TbSubscrbtionHeaders = new HashSet<TbSubscrbtionHeader>();
            TbUserBranches = new HashSet<TbUserBranche>();
        }

        public int UserId { get; set; }
        public int? UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public bool? UserActive { get; set; }
        public int? ComId { get; set; }
        public byte[] UserImage { get; set; }
        public bool Admin { get; set; }
        public int? UserRole { get; set; }

        public virtual TbCompany Com { get; set; }
        public virtual TbRole UserRoleNavigation { get; set; }
        public virtual ICollection<TbLogUserScr> TbLogUserScrs { get; set; }
        public virtual ICollection<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
        public virtual ICollection<TbUserBranche> TbUserBranches { get; set; }
    }
}
