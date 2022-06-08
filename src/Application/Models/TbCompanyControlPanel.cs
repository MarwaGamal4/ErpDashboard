using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCompanyControlPanel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? PeriodId { get; set; }
        public bool? MoreCurrancy { get; set; }
        public bool? ShowCurrencyscreen { get; set; }
        public string DublicateNumber { get; set; }
        public bool? OpeningEntry { get; set; }
        public bool? ShowControlpanel { get; set; }
        public bool? BankAccount { get; set; }
        public string AccountLenth { get; set; }
        public string IntermediateAccount { get; set; }
        public string RevenueNo { get; set; }
        public string ExpensesNo { get; set; }
        public string Suppliers { get; set; }
        public string Customers { get; set; }
        public string Cash { get; set; }
        public string CashAccount { get; set; }
        public int? LastPeriod { get; set; }
        public int? NextPeriod { get; set; }
        public string BranchAccount { get; set; }
        public bool? NotifyItemExpire { get; set; }
        public int? DaysItemExpire { get; set; }
        public string BranchSAccount { get; set; }
        public string BranchCostAccount { get; set; }
        public string StoreCostAccount { get; set; }
        public string DriverAccount { get; set; }
        public string FranciseAccount { get; set; }
        public string ThirdPartAccount { get; set; }
        public string StoreCash { get; set; }
        public string FirstGoods { get; set; }
        public string GoodsStock { get; set; }
        public string MyProperty { get; set; }
        public string CostOfGoodsSold { get; set; }
        public string StoreInventory { get; set; }
        public string Nfcsells { get; set; }
        public string BranchesSells { get; set; }
        public string StoreSells { get; set; }
        public string StorePurchaseDiscount { get; set; }
        public string StoreSellsDiscount { get; set; }
        public string StoreAddValue { get; set; }
        public string StoreTax { get; set; }
        public string StoreDamageGoods { get; set; }
        public string BranchPurchaseDiscount { get; set; }
        public string BranchSellsDiscount { get; set; }
        public string BranchAddValue { get; set; }
        public string BranchTax { get; set; }
        public string BranchDamageGoods { get; set; }
        public string BranchCostOfGoodsSold { get; set; }
        public string BranchStock { get; set; }
        public bool TaxActive { get; set; }
        public decimal TaxPercnt { get; set; }
        public string BankCommission { get; set; }
        public int TaxPosition { get; set; }
        public string CustomerCredit { get; set; }
        public string SubscriptionRevenue { get; set; }
        public string SubscriptionTax { get; set; }
        public string SubscriptionDiscount { get; set; }
        public string NfcLossProfit { get; set; }
        public string UndeliveryDay { get; set; }
        public bool IsIncluedTax { get; set; }

        public virtual TbCompany Company { get; set; }
        public virtual TbFinancialPeriod Period { get; set; }
    }
}
