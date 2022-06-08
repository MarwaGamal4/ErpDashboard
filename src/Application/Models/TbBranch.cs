using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbBranch
    {
        public TbBranch()
        {
            TbNfcOperations = new HashSet<TbNfcOperation>();
            TbTransactionHeaders = new HashSet<TbTransactionHeader>();
            TbTransactionProps = new HashSet<TbTransactionProp>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string OtherAccount { get; set; }
        public string Notes { get; set; }
        public int? ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public string MainAccount { get; set; }
        public string Costnumber { get; set; }
        public string CashNumber { get; set; }
        public string FirstGoodsAccount { get; set; }
        public string CostOfSoldGoodsAccount { get; set; }
        public string StoreInventoryAccount { get; set; }
        public string StoreStockAccount { get; set; }
        public string StoreSells { get; set; }
        public string StorePurchaseDiscount { get; set; }
        public string StoreSellsDiscount { get; set; }
        public string StoreAddValue { get; set; }
        public string StoreTax { get; set; }
        public string StoreDamageGoods { get; set; }
        public string BankAccounts { get; set; }

        public virtual ICollection<TbNfcOperation> TbNfcOperations { get; set; }
        public virtual ICollection<TbTransactionHeader> TbTransactionHeaders { get; set; }
        public virtual ICollection<TbTransactionProp> TbTransactionProps { get; set; }
    }
}
