using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbArea
    {
        public TbArea()
        {
            TbCustomerAdresses = new HashSet<TbCustomerAdress>();
        }

        public int Id { get; set; }
        public int? AreaId { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public int? CityGovernId { get; set; }
        public int BranchId { get; set; }
        public int DriverId { get; set; }
        public int? ComId { get; set; }

        public virtual TbErbMainBranch Branch { get; set; }
        public virtual TbCity City { get; set; }
        public virtual TbGovernorate CityGovern { get; set; }
        public virtual TbDriver Driver { get; set; }
        public virtual ICollection<TbCustomerAdress> TbCustomerAdresses { get; set; }
    }
}
