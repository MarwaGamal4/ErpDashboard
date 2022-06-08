using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbNfcType
    {
        public TbNfcType()
        {
            TbNfcOperations = new HashSet<TbNfcOperation>();
        }

        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public decimal IncrPerc { get; set; }
        public string BancAccounts { get; set; }
        public int? ComId { get; set; }

        public virtual ICollection<TbNfcOperation> TbNfcOperations { get; set; }
    }
}
