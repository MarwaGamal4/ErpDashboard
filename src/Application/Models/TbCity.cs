using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCity
    {
        public TbCity()
        {
            TbAreas = new HashSet<TbArea>();
        }

        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Name { get; set; }
        public int? GovernId { get; set; }
        public int? ComId { get; set; }

        public virtual TbGovernorate Govern { get; set; }
        public virtual ICollection<TbArea> TbAreas { get; set; }
    }
}
