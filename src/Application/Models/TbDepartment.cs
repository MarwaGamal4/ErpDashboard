using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDepartment
    {
        public TbDepartment()
        {
            TbItemsDepartments = new HashSet<TbItemsDepartment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ComId { get; set; }

        public virtual ICollection<TbItemsDepartment> TbItemsDepartments { get; set; }
    }
}
