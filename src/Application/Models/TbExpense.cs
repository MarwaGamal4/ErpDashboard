using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbExpense
    {
        public int Id { get; set; }
        public int? ExpensesId { get; set; }
        public string ExpensesName { get; set; }
        public string ExpensesNameEn { get; set; }
        public string Notes { get; set; }
        public string AccountNo { get; set; }
        public string MainAccount { get; set; }
        public bool Active { get; set; }
        public int ComId { get; set; }
        public int UserId { get; set; }
    }
}
