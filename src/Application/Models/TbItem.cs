using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbItem
    {
        public TbItem()
        {
            TbItemComponentsHdrs = new HashSet<TbItemComponentsHdr>();
            TbItemNutirations = new HashSet<TbItemNutiration>();
            TbItemsDepartments = new HashSet<TbItemsDepartment>();
            TbItemsSections = new HashSet<TbItemsSection>();
            TbMealsLines = new HashSet<TbMealsLine>();
            TbTransactionDetails = new HashSet<TbTransactionDetail>();
        }

        public int Id { get; set; }
        public int? ItemId { get; set; }
        public string ItemId2 { get; set; }
        public string ItemEnName { get; set; }
        public int? CategoryId { get; set; }
        public int? MenueSectionId { get; set; }
        public string ItemCase { get; set; }
        public int ItemType { get; set; }
        public int? ItemUnit1 { get; set; }
        public int? ItemUnit2 { get; set; }
        public int? ItemUnit3 { get; set; }
        public decimal? UnitRate1 { get; set; }
        public int? MainUnit { get; set; }
        public int MainUnitId { get; set; }
        public decimal? UnitRate2 { get; set; }
        public decimal? UnitRate3 { get; set; }
        public decimal? RequestUnit1 { get; set; }
        public decimal? MinRequestUnit1 { get; set; }
        public decimal? MaxRequestUnit1 { get; set; }
        public decimal? RequestUnit2 { get; set; }
        public decimal? MinRequestUnit2 { get; set; }
        public decimal? MaxRequestUnit2 { get; set; }
        public decimal? RequestUnit3 { get; set; }
        public decimal? MinRequestUnit3 { get; set; }
        public decimal? MaxRequestUnit3 { get; set; }
        public int? ItemPricesId { get; set; }
        public int? ComId { get; set; }
        public bool? ItemActive { get; set; }
        public bool? ExpireFlag { get; set; }
        public decimal? CostPrice { get; set; }

        public virtual TbCategory Category { get; set; }
        public virtual TbItemPrice ItemPrices { get; set; }
        public virtual TbUnit ItemUnit1Navigation { get; set; }
        public virtual TbMenuSection MenueSection { get; set; }
        public virtual ICollection<TbItemComponentsHdr> TbItemComponentsHdrs { get; set; }
        public virtual ICollection<TbItemNutiration> TbItemNutirations { get; set; }
        public virtual ICollection<TbItemsDepartment> TbItemsDepartments { get; set; }
        public virtual ICollection<TbItemsSection> TbItemsSections { get; set; }
        public virtual ICollection<TbMealsLine> TbMealsLines { get; set; }
        public virtual ICollection<TbTransactionDetail> TbTransactionDetails { get; set; }
    }
}
