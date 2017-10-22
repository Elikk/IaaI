using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos
{
    public class AuctionListItemSaleDTO
    {
        public int AuctionID { get; set; }
        public int SalePrice { get; set; }
        public string CrossCheckString { get; set; }


        public AuctionListItemSale ToEntity()
        {
            AuctionListItemSale entity = new AuctionListItemSale();

            entity.AuctionID = this.AuctionID;
            entity.CrossCheckString = this.CrossCheckString;
            entity.SalePrice = this.SalePrice;
            entity.CreatedDateTime = DateTime.Now;

            return entity;
        }
    }
}
