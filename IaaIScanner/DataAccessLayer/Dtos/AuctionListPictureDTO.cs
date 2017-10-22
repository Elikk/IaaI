using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos
{
    public class AuctionListPictureDTO
    {
        public int AuctionID { get; set; }
        public int AuctionListItemNumber { get; set; }
        public byte[] PictureString  { get; set; }


        public AuctionListPicture ToEntity()
        {
            AuctionListPicture entity = new AuctionListPicture();

            entity.AuctionID = this.AuctionID;
            entity.AuctionListItemNumber = this.AuctionListItemNumber;
            entity.Picture = this.PictureString;
            entity.CreatedDateTime = DateTime.Now;
            return entity;
        }
    }

}
