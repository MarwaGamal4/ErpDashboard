using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCurrencyPrice
    {
        public int CurPrId { get; set; }
        public int? CurId { get; set; }
        public decimal? PurPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Rate { get; set; }
        public DateTime CurDatetime { get; set; }
        public int? ComId { get; set; }

        public virtual TbCompany Com { get; set; }
        public virtual TbCurrency Cur { get; set; }
    }
}
