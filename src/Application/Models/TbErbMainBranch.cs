using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbErbMainBranch
    {
        public TbErbMainBranch()
        {
            TbAreas = new HashSet<TbArea>();
            TbDrivers = new HashSet<TbDriver>();
            TbPayTypeHeaderTbErbMainBranches = new HashSet<TbPayTypeHeaderTbErbMainBranch>();
            TbSubscrbtionHeaders = new HashSet<TbSubscrbtionHeader>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string OtherAccount { get; set; }
        public string Notes { get; set; }
        public int ComId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public string MainAccount { get; set; }
        public string Costnumber { get; set; }
        public string CashNumber { get; set; }
        public bool Isfranchise { get; set; }
        public string FranchiseAccount { get; set; }
        public decimal Commission { get; set; }
        public string CommisionAccount { get; set; }
        public string BranchSells { get; set; }
        public string BranchPurchaseDiscount { get; set; }
        public string BranchSellsDiscount { get; set; }
        public string BranchAddValue { get; set; }
        public string BranchTax { get; set; }
        public string BranchDamageGoods { get; set; }
        public string BranchCostOfGoodsSold { get; set; }
        public string BranchStock { get; set; }
        public bool Hasdelivery { get; set; }
        public string BranchSymbol { get; set; }

        public virtual TbCompany Com { get; set; }
        public virtual ICollection<TbArea> TbAreas { get; set; }
        public virtual ICollection<TbDriver> TbDrivers { get; set; }
        public virtual ICollection<TbPayTypeHeaderTbErbMainBranch> TbPayTypeHeaderTbErbMainBranches { get; set; }
        public virtual ICollection<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
    }
}
