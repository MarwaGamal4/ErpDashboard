using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbSystemLogger
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string PrimaryKey { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifaiedOn { get; set; }
        public string TableName { get; set; }
        public string PropertyName { get; set; }
    }
}
