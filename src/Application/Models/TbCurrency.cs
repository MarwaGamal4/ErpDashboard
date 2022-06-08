using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCurrency
    {
        public TbCurrency()
        {
            TbCurrencyPrices = new HashSet<TbCurrencyPrice>();
            TbInvoicePaymentsHdrs = new HashSet<TbInvoicePaymentsHdr>();
            TbNfcOperations = new HashSet<TbNfcOperation>();
            TbPaymentVoucherHdrs = new HashSet<TbPaymentVoucherHdr>();
            TbRestrictionHdrs = new HashSet<TbRestrictionHdr>();
        }

        public int CurId { get; set; }
        public string CurName { get; set; }
        public string CurNameEn { get; set; }
        public string CurSmall { get; set; }
        public string CurSmallEn { get; set; }
        public bool? CurActive { get; set; }
        public int? CurDefRate { get; set; }
        public string CurSymbol { get; set; }
        public int? ComId { get; set; }

        public virtual ICollection<TbCurrencyPrice> TbCurrencyPrices { get; set; }
        public virtual ICollection<TbInvoicePaymentsHdr> TbInvoicePaymentsHdrs { get; set; }
        public virtual ICollection<TbNfcOperation> TbNfcOperations { get; set; }
        public virtual ICollection<TbPaymentVoucherHdr> TbPaymentVoucherHdrs { get; set; }
        public virtual ICollection<TbRestrictionHdr> TbRestrictionHdrs { get; set; }
    }
}
