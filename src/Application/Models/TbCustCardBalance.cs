using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustCardBalance
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public DateTime OpDatetime { get; set; }
        public int CardId { get; set; }
        public decimal MoneyAmount { get; set; }
        public string InOut { get; set; }

        public virtual TbCustomer Cust { get; set; }
    }
}
