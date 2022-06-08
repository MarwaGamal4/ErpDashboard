using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbGovernorate
    {
        public TbGovernorate()
        {
            TbAreas = new HashSet<TbArea>();
            TbCities = new HashSet<TbCity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ComId { get; set; }
        public int? GovernId { get; set; }

        public virtual ICollection<TbArea> TbAreas { get; set; }
        public virtual ICollection<TbCity> TbCities { get; set; }
    }
}
