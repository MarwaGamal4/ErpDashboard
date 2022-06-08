using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbScreen
    {
        public TbScreen()
        {
            TbLogUserScrs = new HashSet<TbLogUserScr>();
        }

        public int Id { get; set; }
        public string ScrName { get; set; }
        public string ScrNameEn { get; set; }

        public virtual ICollection<TbLogUserScr> TbLogUserScrs { get; set; }
    }
}
