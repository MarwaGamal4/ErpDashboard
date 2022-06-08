using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMealsType
    {
        public TbMealsType()
        {
            TbManyTypeMeals = new HashSet<TbManyTypeMeal>();
            TbPlanHdrTypes = new HashSet<TbPlanHdrType>();
            TbPlanMasterLines = new HashSet<TbPlanMasterLine>();
            TbSubscrbtionDetails = new HashSet<TbSubscrbtionDetail>();
        }

        public int Id { get; set; }
        public int? MTypeId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool Selected { get; set; }
        public int? ComId { get; set; }

        public virtual TbMealsCategory Category { get; set; }
        public virtual ICollection<TbManyTypeMeal> TbManyTypeMeals { get; set; }
        public virtual ICollection<TbPlanHdrType> TbPlanHdrTypes { get; set; }
        public virtual ICollection<TbPlanMasterLine> TbPlanMasterLines { get; set; }
        public virtual ICollection<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
    }
}
