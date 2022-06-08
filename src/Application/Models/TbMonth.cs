using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbMonth
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public decimal? يناير { get; set; }
        public decimal? فبراير { get; set; }
        public decimal? مارس { get; set; }
        public decimal? أبريل { get; set; }
        public decimal? مايو { get; set; }
        public decimal? يونيو { get; set; }
        public decimal? يوليو { get; set; }
        public decimal? أغسطس { get; set; }
        public decimal? سبتمبر { get; set; }
        public decimal? أكتوبر { get; set; }
        public decimal? نوفمبر { get; set; }
        public decimal? ديسمبر { get; set; }
    }
}
