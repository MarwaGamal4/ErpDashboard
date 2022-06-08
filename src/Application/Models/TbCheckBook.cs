using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCheckBook
    {
        public TbCheckBook()
        {
            TbBankTransHdrs = new HashSet<TbBankTransHdr>();
        }

        public int ChBookId { get; set; }
        public int? ChBookCode { get; set; }
        public int? BankId { get; set; }
        public int? StartWith { get; set; }
        public int? EndWith { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public int? CurrentCheckId { get; set; }

        public virtual TbBanksInfo Bank { get; set; }
        public virtual ICollection<TbBankTransHdr> TbBankTransHdrs { get; set; }
    }
}
