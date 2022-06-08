using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbTransactionHeader
    {
        public TbTransactionHeader()
        {
            TbTransactionDetails = new HashSet<TbTransactionDetail>();
            TbTransctionsOtherAdds = new HashSet<TbTransctionsOtherAdd>();
        }

        public int Id { get; set; }
        public int? TransactionId { get; set; }
        public int? RelatedId { get; set; }
        public int? TransactionType { get; set; }
        public string TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public TimeSpan? TransactionTime { get; set; }
        public int? AccountId { get; set; }
        public int? StoreId { get; set; }
        public string RelatedScreen { get; set; }
        public int? CurrancyId { get; set; }
        public string Notes { get; set; }
        public string PayType { get; set; }
        public decimal? ItemsDiscount { get; set; }
        public decimal? TransactionDiscount { get; set; }
        public decimal? TotalAfterDiscount { get; set; }
        public decimal? NetVal { get; set; }
        public decimal? QtyTot { get; set; }
        public decimal? TransactionExpense { get; set; }
        public decimal? SalesTax { get; set; }
        public decimal? AddValue { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public decimal? CurrancyRate { get; set; }
        public decimal? ItemDicountPercent { get; set; }
        public decimal? TransactionTotal { get; set; }
        public decimal? TransActionDiscountercent { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public decimal? AddTaxPercent { get; set; }
        public int? FinId { get; set; }
        public string VisaBank { get; set; }
        public int? RestId { get; set; }
        public int? StoreTo { get; set; }

        public virtual TbCustomersVendor Account { get; set; }
        public virtual TbBranch Store { get; set; }
        public virtual TbRestrictionsType TransactionTypeNavigation { get; set; }
        public virtual ICollection<TbTransactionDetail> TbTransactionDetails { get; set; }
        public virtual ICollection<TbTransctionsOtherAdd> TbTransctionsOtherAdds { get; set; }
    }
}
