using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDiscountOption
    {
        public TbDiscountOption()
        {
            TbGeneralDiscounts = new HashSet<TbGeneralDiscount>();
            TbSponserDiscounts = new HashSet<TbSponserDiscount>();
        }

        public int Id { get; set; }
        public int DiscId { get; set; }
        public bool MoreCustBenefit { get; set; }
        public bool OtherDiscBenefit { get; set; }
        public bool MiniToBenefit { get; set; }
        public bool MaxToBenefit { get; set; }
        public bool RelatedToSponser { get; set; }
        public bool ApplyNewCust { get; set; }
        public bool MaxLimitPercValue { get; set; }
        public bool ValueOrPerc { get; set; }
        public bool DiscOnPlans { get; set; }
        public bool DiscOnCust { get; set; }
        public bool MaxCustBenefits { get; set; }
        public string Plans { get; set; }
        public string Customers { get; set; }
        public int? MaxCustVal { get; set; }
        public decimal? MaxBenefitVal { get; set; }
        public decimal? MaxPercValue { get; set; }
        public string Sponsers { get; set; }
        public decimal? MiniBenefitVal { get; set; }

        public virtual ICollection<TbGeneralDiscount> TbGeneralDiscounts { get; set; }
        public virtual ICollection<TbSponserDiscount> TbSponserDiscounts { get; set; }
    }
}
