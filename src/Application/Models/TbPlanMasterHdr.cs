using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbPlanMasterHdr
    {
        public TbPlanMasterHdr()
        {
            TbPlanHdrTypes = new HashSet<TbPlanHdrType>();
            TbPlanMasterLines = new HashSet<TbPlanMasterLine>();
            TbPlanPrices = new HashSet<TbPlanPrice>();
            TbSubscrbtionHeaders = new HashSet<TbSubscrbtionHeader>();
        }

        public int Id { get; set; }
        public int PlanId { get; set; }
        public int DaysCount { get; set; }
        public int StartDay { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public string PlanName { get; set; }
        public string DefaultSticker { get; set; }
        public int Pointer { get; set; }
        public DateTime PointerDate { get; set; }
        public string PlanExprission { get; set; }
        public int ComId { get; set; }
        public int PlanCategory { get; set; }

        public virtual TbPlanCategory PlanCategoryNavigation { get; set; }
        public virtual ICollection<TbPlanHdrType> TbPlanHdrTypes { get; set; }
        public virtual ICollection<TbPlanMasterLine> TbPlanMasterLines { get; set; }
        public virtual ICollection<TbPlanPrice> TbPlanPrices { get; set; }
        public virtual ICollection<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
    }
}
