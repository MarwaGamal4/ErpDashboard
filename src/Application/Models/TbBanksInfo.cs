using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbBanksInfo
    {
        public TbBanksInfo()
        {
            TbBankTransHdrs = new HashSet<TbBankTransHdr>();
            TbCheckBooks = new HashSet<TbCheckBook>();
        }

        public int Id { get; set; }
        public int? BankId { get; set; }
        public string BankName { get; set; }
        public string BankNameEn { get; set; }
        public string BankAccountNum { get; set; }
        public string AccountTreeNum { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public bool UseBankComission { get; set; }
        public string AccountNumber { get; set; }
        public string CommissionAcc { get; set; }
        public decimal? CommissionRate { get; set; }
        public string CommissionAccName { get; set; }

        public virtual TbCompany Com { get; set; }
        public virtual ICollection<TbBankTransHdr> TbBankTransHdrs { get; set; }
        public virtual ICollection<TbCheckBook> TbCheckBooks { get; set; }
    }
}
