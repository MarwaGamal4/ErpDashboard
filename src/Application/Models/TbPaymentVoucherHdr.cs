using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPaymentVoucherHdr
    {
        public TbPaymentVoucherHdr()
        {
            TbPaymentVoucherLines = new HashSet<TbPaymentVoucherLine>();
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
        public string AccountA { get; set; }
        public string AccountB { get; set; }
        public decimal? AmountA { get; set; }
        public decimal? AmountB { get; set; }
        public decimal? RestValue { get; set; }
        public string MoveType { get; set; }
        public int? RestId1 { get; set; }
        public bool? Cost1 { get; set; }
        public bool? Cost2 { get; set; }
        public int? RestType { get; set; }

        public virtual TbCurrency RestCur { get; set; }
        public virtual TbRestrictionsType RestTypeNavigation { get; set; }
        public virtual ICollection<TbPaymentVoucherLine> TbPaymentVoucherLines { get; set; }
    }
}
