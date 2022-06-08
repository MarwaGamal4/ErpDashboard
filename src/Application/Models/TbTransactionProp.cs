using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbTransactionProp
    {
        public int Id { get; set; }
        public int? ScreenName { get; set; }
        public string MaterialAccount { get; set; }
        public string PurchaseAccount { get; set; }
        public string Voucher { get; set; }
        public string CashAccount { get; set; }
        public string CostOfGoods { get; set; }
        public string DiscountAccount { get; set; }
        public string SalesTax { get; set; }
        public string GoadsOnWay { get; set; }
        public string ValueAdded { get; set; }
        public string VisaAccount { get; set; }
        public string Notes { get; set; }
        public string EntryType { get; set; }
        public int PriceType { get; set; }
        public int? Store { get; set; }
        public bool? UseExpireItem { get; set; }
        public int? ComId { get; set; }
        public decimal? DiscVal { get; set; }
        public bool? CreateEntry { get; set; }
        public bool EffectOnAvg { get; set; }
        public bool? ReManualCode { get; set; }
        public string ManualCodeOption { get; set; }
        public string ExpireItemOption { get; set; }
        public int? NoyifyExpire { get; set; }
        public string PayType { get; set; }
        public bool? InvVendorDisc { get; set; }

        public virtual TbPriceType PriceTypeNavigation { get; set; }
        public virtual TbBranch StoreNavigation { get; set; }
    }
}
