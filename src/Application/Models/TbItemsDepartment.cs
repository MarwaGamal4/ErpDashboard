using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbItemsDepartment
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public int DeptId { get; set; }
        public int ItemId { get; set; }

        public virtual TbDepartment Dept { get; set; }
        public virtual TbItem Item { get; set; }
    }
}
