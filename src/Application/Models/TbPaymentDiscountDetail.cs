using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPaymentDiscountDetail
    {
        public int Id { get; set; }
        public int PaymentDetailsId { get; set; }
        public int DiscountId { get; set; }
        public decimal DiscountValue { get; set; }
        public string CouponCode { get; set; }
        public int DiscountType { get; set; }
        public int CustomerId { get; set; }

        public virtual TbCustomer Customer { get; set; }
        public virtual TbInvoicePaymentsHdr PaymentDetails { get; set; }
    }
}
