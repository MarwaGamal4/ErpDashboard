using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPayTypeHeader
    {
        public TbPayTypeHeader()
        {
            TbPayTypeHeaderTbErbMainBranches = new HashSet<TbPayTypeHeaderTbErbMainBranch>();
            TbPayTypeLines = new HashSet<TbPayTypeLine>();
            TbPaymentMethodDetails = new HashSet<TbPaymentMethodDetail>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public int Type { get; set; }
        public int? ThirdPartType { get; set; }
        public bool IsActive { get; set; }
        public decimal? Commation { get; set; }
        public string RefranceId { get; set; }
        public string CardId { get; set; }

        public virtual ICollection<TbPayTypeHeaderTbErbMainBranch> TbPayTypeHeaderTbErbMainBranches { get; set; }
        public virtual ICollection<TbPayTypeLine> TbPayTypeLines { get; set; }
        public virtual ICollection<TbPaymentMethodDetail> TbPaymentMethodDetails { get; set; }
    }
}
