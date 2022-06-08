using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCompany
    {
        public TbCompany()
        {
            TbBanksInfos = new HashSet<TbBanksInfo>();
            TbCompanyControlPanels = new HashSet<TbCompanyControlPanel>();
            TbCurrencyPrices = new HashSet<TbCurrencyPrice>();
            TbErbMainBranches = new HashSet<TbErbMainBranch>();
            TbRestrictionHdrs = new HashSet<TbRestrictionHdr>();
            TbSubscrbtionHeaders = new HashSet<TbSubscrbtionHeader>();
            TbUsers = new HashSet<TbUser>();
        }

        public int ComId { get; set; }
        public string ComName { get; set; }
        public string ComNameEn { get; set; }
        public bool? ComActive { get; set; }
        public string ComTelephone1 { get; set; }
        public string ComTelephone2 { get; set; }
        public string ComMobile1 { get; set; }
        public string ComMobile2 { get; set; }
        public string ComAddress { get; set; }
        public string ComMailBox { get; set; }
        public string ComTaxCard { get; set; }
        public string ComCommercialRecord { get; set; }
        public string ComNameRpt { get; set; }
        public string ComNameEnRpt { get; set; }
        public string CompanySymbol { get; set; }

        public virtual ICollection<TbBanksInfo> TbBanksInfos { get; set; }
        public virtual ICollection<TbCompanyControlPanel> TbCompanyControlPanels { get; set; }
        public virtual ICollection<TbCurrencyPrice> TbCurrencyPrices { get; set; }
        public virtual ICollection<TbErbMainBranch> TbErbMainBranches { get; set; }
        public virtual ICollection<TbRestrictionHdr> TbRestrictionHdrs { get; set; }
        public virtual ICollection<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
        public virtual ICollection<TbUser> TbUsers { get; set; }
    }
}
