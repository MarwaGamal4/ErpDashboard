using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustomerLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
        public int Actionstypes { get; set; }
        public int Cid { get; set; }

        public virtual TbSubscrbtionHeader CidNavigation { get; set; }
        public virtual TbCustomer Customer { get; set; }
    }
}
