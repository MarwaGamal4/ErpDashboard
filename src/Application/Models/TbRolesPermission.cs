using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbRolesPermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string RoleValue { get; set; }
        public int ComId { get; set; }

        public virtual TbRole Role { get; set; }
    }
}
