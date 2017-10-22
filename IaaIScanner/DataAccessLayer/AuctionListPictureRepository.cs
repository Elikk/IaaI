using DataAccessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AuctionListPictureRepository
    {
        iaaiEntities context;
        public AuctionListPictureRepository()
        {
            context = new iaaiEntities();
        }

        public void Add(AuctionListPictureDTO auctionListPictureDTO)
        {
            context.AuctionListPictures.Add(auctionListPictureDTO.ToEntity());
            context.SaveChanges();
        }
    }
}
