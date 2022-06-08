using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPaymentMethodDetail
    {
        public int Id { get; set; }
        public int PaymentsDetailsId { get; set; }
        public int MethodId { get; set; }
        public decimal Amount { get; set; }
        public string RefrenceId { get; set; }

        public virtual TbPayTypeHeader Method { get; set; }
        public virtual TbInvoicePaymentsHdr PaymentsDetails { get; set; }
    }
}
