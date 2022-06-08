using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbCustomersPhone
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Phone { get; set; }
        public string PhoneType { get; set; }

        public virtual TbCustomer Customer { get; set; }
    }
}
