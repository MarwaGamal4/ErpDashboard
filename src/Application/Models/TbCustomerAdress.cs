using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustomerAdress
    {
        public TbCustomerAdress()
        {
            TbSubscrbtionDetails = new HashSet<TbSubscrbtionDetail>();
        }

        public int Id { get; set; }
        public int AreaId { get; set; }
        public int CustomerId { get; set; }
        public string Adress { get; set; }
        public bool DefaultAdress { get; set; }

        public virtual TbArea Area { get; set; }
        public virtual TbCustomer Customer { get; set; }
        public virtual ICollection<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
    }
}
