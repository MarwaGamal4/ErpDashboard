using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbBankTransHdr
    {
        public TbBankTransHdr()
        {
            TbBankTransLines = new HashSet<TbBankTransLine>();
        }

        public int RestId { get; set; }
        public int? RestCode { get; set; }
        public int ResFinCode { get; set; }
        public int? RestMonthId { get; set; }
        public DateTime RestDatetime { get; set; }
        public string RestNote { get; set; }
        public int? RestCurId { get; set; }
        public decimal? RestCurRate { get; set; }
        public string RestCase { get; set; }
        public int? ComId { get; set; }
        public int? FinPeriod { get; set; }
        public decimal? RestValue { get; set; }
        public string RestFlag { get; set; }
        public int? BankId { get; set; }
        public int? CheckBookId { get; set; }
        public int? CheckId { get; set; }
        public string BankAccNum { get; set; }
        public string CheckCase { get; set; }
        public string RestUser { get; set; }
        public int? RestId1 { get; set; }
        public bool? Cost1 { get; set; }
        public bool? Cost2 { get; set; }
        public int? RestType { get; set; }

        public virtual TbBanksInfo Bank { get; set; }
        public virtual TbCheckBook CheckBook { get; set; }
        public virtual TbRestrictionsType RestTypeNavigation { get; set; }
        public virtual ICollection<TbBankTransLine> TbBankTransLines { get; set; }
    }
}
