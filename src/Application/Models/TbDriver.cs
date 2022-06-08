using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbDriver
    {
        public TbDriver()
        {
            TbAreas = new HashSet<TbArea>();
            TbSubscrbtionDetails = new HashSet<TbSubscrbtionDetail>();
            TbSubscrbtionHeaders = new HashSet<TbSubscrbtionHeader>();
        }

        public int Id { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public int BranchId { get; set; }
        public byte[] DriverImage { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Adress { get; set; }
        public string Notes { get; set; }
        public int ComId { get; set; }
        public string AccountNo { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }

        public virtual TbErbMainBranch Branch { get; set; }
        public virtual ICollection<TbArea> TbAreas { get; set; }
        public virtual ICollection<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
        public virtual ICollection<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
    }
}
