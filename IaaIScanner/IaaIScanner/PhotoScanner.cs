using DataAccessLayer;
using DataAccessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaaIScanner
{
    public class PhotoScanner
    {
        private int listItemNumber = 0;
        private List<FileSystemInfo> files;
        private AuctionListPictureRepository repo;

        public PhotoScanner(List<FileSystemInfo> files)
        {
            this.files = files;
            repo = new AuctionListPictureRepository();
        }

        public void EnumerateAndWriteToDB()
        {
            foreach(var file in files)
            {
                if(file.FullName.EndsWith(".json"))
                {
                    var content = File.ReadAllText(file.FullName);
                    if (content.Contains(@"objectId\"":\""group\"",\""data\"":{\""groupItemList\"":[\"""))
                    {
                        var firstSplit = content.Split(new string[] { @"objectId\"":\""group\"",\""data\"":{\""groupItemList\"":[\""" }, StringSplitOptions.None)[1].ToString();
                        var secondSplit = firstSplit.Split(new string[] { @"\" }, StringSplitOptions.None)[0].ToString();
                        int.TryParse(secondSplit, out listItemNumber);
                    }

                }
                else if (file.FullName.EndsWith(".jpg") && listItemNumber != 0)
                {
                    
                    var item = new AuctionListPictureDTO();
                    item.PictureString = File.ReadAllBytes(file.FullName);
                    item.AuctionListItemNumber = listItemNumber;
                    item.AuctionID = 8;
                    repo.Add(item);
                }


            }
        }

      
    }
}
