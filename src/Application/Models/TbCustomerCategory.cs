using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustomerCategory
    {
        public TbCustomerCategory()
        {
            TbCustomers = new HashSet<TbCustomer>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ComId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<TbCustomer> TbCustomers { get; set; }
    }
}
