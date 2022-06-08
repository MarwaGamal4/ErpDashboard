using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbEntryAttatchment
    {
        public TbEntryAttatchment()
        {
            TbRestrictionHdrs = new HashSet<TbRestrictionHdr>();
        }

        public int Id { get; set; }
        public int? AttatchId { get; set; }
        public int? EntryId { get; set; }
        public string AttatchName { get; set; }
        public string EntryType { get; set; }
        public DateTime? RememberData { get; set; }
        public string Extentions { get; set; }
        public byte[] AttatchFile { get; set; }
        public bool? Status { get; set; }
        public int? ComId { get; set; }
        public string AttatchPath { get; set; }
        public int? UserId { get; set; }
        public bool? NotShowAgain { get; set; }

        public virtual ICollection<TbRestrictionHdr> TbRestrictionHdrs { get; set; }
    }
}
