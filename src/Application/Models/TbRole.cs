using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbRole
    {
        public TbRole()
        {
            TbRolesPermissions = new HashSet<TbRolesPermission>();
            TbUsers = new HashSet<TbUser>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<TbRolesPermission> TbRolesPermissions { get; set; }
        public virtual ICollection<TbUser> TbUsers { get; set; }
    }
}
