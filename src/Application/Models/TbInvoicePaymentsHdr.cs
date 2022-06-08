using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbInvoicePaymentsHdr
    {
        public TbInvoicePaymentsHdr()
        {
            TbPaymentDiscountDetails = new HashSet<TbPaymentDiscountDetail>();
            TbPaymentMethodDetails = new HashSet<TbPaymentMethodDetail>();
            TbSubscrbtionDetails = new HashSet<TbSubscrbtionDetail>();
        }

        public int Id { get; set; }
        public int SubscrbtionId { get; set; }
        public int CustomerId { get; set; }
        public int FinId { get; set; }
        public int CurrancyId { get; set; }
        public decimal CurrancyRate { get; set; }
        public int CustomerType { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public decimal Tax { get; set; }
        public int InvoiceType { get; set; }
        public int InvoiceState { get; set; }
        public int SubscriptionType { get; set; }
        public int? SubscripBranch { get; set; }
        public string Notes { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ActionDate { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal ManualDiscount { get; set; }
        public byte[] InvoiceAttatchment { get; set; }
        public bool Confirmed { get; set; }
        public int ConfirmUser { get; set; }
        public string InvoiceSerial { get; set; }

        public virtual TbCurrency Currancy { get; set; }
        public virtual TbSubscrbtionHeader Subscrbtion { get; set; }
        public virtual ICollection<TbPaymentDiscountDetail> TbPaymentDiscountDetails { get; set; }
        public virtual ICollection<TbPaymentMethodDetail> TbPaymentMethodDetails { get; set; }
        public virtual ICollection<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
    }
}
