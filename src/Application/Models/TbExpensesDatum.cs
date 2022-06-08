using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbExpensesDatum
    {
        public int Id { get; set; }
        public int ExpensesId { get; set; }
        public int ManualId { get; set; }
        public DateTime Date { get; set; }
        public string Response { get; set; }
        public string ExpenseAccount { get; set; }
        public string BranchId { get; set; }
        public int StoreId { get; set; }
        public string PayType { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string LoadType { get; set; }
        public string BankId { get; set; }
        public int ComId { get; set; }
        public int UserId { get; set; }
        public int ResetId { get; set; }
        public int CurrancyId { get; set; }
        public decimal CurRate { get; set; }
    }
}
