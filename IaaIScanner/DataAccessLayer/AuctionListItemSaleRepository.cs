using DataAccessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AuctionListItemSaleRepository
    {
        iaaiEntities context;
        public AuctionListItemSaleRepository()
        {
            context = new iaaiEntities();
        }

        public void Add(AuctionListItemSaleDTO auctionListItemSaleDTO)
        {
            context.AuctionListItemSales.Add(auctionListItemSaleDTO.ToEntity());
            context.SaveChanges();
        }
    }
}
