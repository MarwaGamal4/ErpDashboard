using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDislikeCategorytbSubscrbtionHeader
    {
        public int TbDislikeCategoryId { get; set; }
        public int TbSubscrbtionHeaderId { get; set; }

        public virtual TbDislikeCategory TbDislikeCategory { get; set; }
        public virtual TbSubscrbtionHeader TbSubscrbtionHeader { get; set; }
    }
}
