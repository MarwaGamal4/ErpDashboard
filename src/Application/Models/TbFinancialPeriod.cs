using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbFinancialPeriod
    {
        public TbFinancialPeriod()
        {
            TbCompanyControlPanels = new HashSet<TbCompanyControlPanel>();
        }

        public int FinancialId { get; set; }
        public string FinancialName { get; set; }
        public string FinancialNameEn { get; set; }
        public bool? FinancialCase { get; set; }
        public DateTime FinancialStartIn { get; set; }
        public DateTime FinancialEndIn { get; set; }
        public int? ComId { get; set; }

        public virtual ICollection<TbCompanyControlPanel> TbCompanyControlPanels { get; set; }
    }
}
