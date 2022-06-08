using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDislikeCategory
    {
        public TbDislikeCategory()
        {
            TbDislikeCategorytbSubscrbtionHeaders = new HashSet<TbDislikeCategorytbSubscrbtionHeader>();
            TbDislikeItems = new HashSet<TbDislikeItem>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ComId { get; set; }

        public virtual ICollection<TbDislikeCategorytbSubscrbtionHeader> TbDislikeCategorytbSubscrbtionHeaders { get; set; }
        public virtual ICollection<TbDislikeItem> TbDislikeItems { get; set; }
    }
}
