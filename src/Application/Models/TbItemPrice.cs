using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbItemPrice
    {
        public TbItemPrice()
        {
            TbItems = new HashSet<TbItem>();
        }

        public int Id { get; set; }
        public int? ItemId { get; set; }
        public decimal? PurPrice1Unt1 { get; set; }
        public decimal? PurPrice1Unt2 { get; set; }
        public decimal? PurPrice1Unt3 { get; set; }
        public decimal? PurPrice2Unt1 { get; set; }
        public decimal? PurPrice2Unt2 { get; set; }
        public decimal? PurPrice2Unt3 { get; set; }
        public decimal? PurPrice3Unt1 { get; set; }
        public decimal? PurPrice3Unt2 { get; set; }
        public decimal? PurPrice3Unt3 { get; set; }
        public decimal? PurPrice4Unt1 { get; set; }
        public decimal? PurPrice4Unt2 { get; set; }
        public decimal? PurPrice4Unt3 { get; set; }
        public decimal? PurPrice5Unt1 { get; set; }
        public decimal? PurPrice5Unt2 { get; set; }
        public decimal? PurPrice5Unt3 { get; set; }
        public decimal? AvgPurPrice { get; set; }
        public decimal? AvgPurPrice3 { get; set; }
        public decimal? AvgPurPrice2 { get; set; }
        public decimal? LastPurPrice { get; set; }
        public decimal? LastPurPrice2 { get; set; }
        public decimal? LastPurPrice3 { get; set; }
        public decimal? SalePrice1Unt1 { get; set; }
        public decimal? SalePrice1Unt2 { get; set; }
        public decimal? SalePrice1Unt3 { get; set; }
        public decimal? SalePrice2Unt1 { get; set; }
        public decimal? SalePrice2Unt2 { get; set; }
        public decimal? SalePrice2Unt3 { get; set; }
        public decimal? SalePrice3Unt1 { get; set; }
        public decimal? SalePrice3Unt2 { get; set; }
        public decimal? SalePrice3Unt3 { get; set; }
        public decimal? SalePrice4Unt1 { get; set; }
        public decimal? SalePrice4Unt2 { get; set; }
        public decimal? SalePrice4Unt3 { get; set; }
        public decimal? SalePrice5Unt1 { get; set; }
        public decimal? SalePrice5Unt2 { get; set; }
        public decimal? SalePrice5Unt3 { get; set; }
        public decimal? AvgSalePrice { get; set; }
        public decimal? AvgSalePrice2 { get; set; }
        public decimal? AvgSalePrice3 { get; set; }
        public decimal? LastSalePrice { get; set; }
        public decimal? LastSalePrice2 { get; set; }
        public decimal? LastSalePrice3 { get; set; }

        public virtual ICollection<TbItem> TbItems { get; set; }
    }
}
