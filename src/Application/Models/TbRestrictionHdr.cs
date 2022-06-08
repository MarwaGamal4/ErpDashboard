using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbRestrictionHdr
    {
        public TbRestrictionHdr()
        {
            TbRestrictionLines = new HashSet<TbRestrictionLine>();
        }

        public int RestId { get; set; }
        public int? RestCode { get; set; }
        public int ResFinCode { get; set; }
        public int? RestMonthId { get; set; }
        public DateTime RestDatetime { get; set; }
        public string RestNote { get; set; }
        public int? RestCurId { get; set; }
        public decimal? RestCurRate { get; set; }
        public string RestCase { get; set; }
        public int? ComId { get; set; }
        public int? FinPeriod { get; set; }
        public decimal? RestValue { get; set; }
        public string RestFlag { get; set; }
        public bool? Cost1 { get; set; }
        public bool? Cost2 { get; set; }
        public int? RelatedId { get; set; }
        public string CheckCase { get; set; }
        public int? RelatedFincialId { get; set; }
        public int? AttatchedId { get; set; }
        public int? RestType { get; set; }
        public int? RestId1 { get; set; }

        public virtual TbEntryAttatchment Attatched { get; set; }
        public virtual TbCompany Com { get; set; }
        public virtual TbCurrency RestCur { get; set; }
        public virtual TbRestrictionsType RestTypeNavigation { get; set; }
        public virtual ICollection<TbRestrictionLine> TbRestrictionLines { get; set; }
    }
}
