using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaaIScanner
{
    public class PriceScanner
    {

        private int listItemNumber = 0;
        private List<FileSystemInfo> files;
        private AuctionListItemSaleRepository repo;

        public PriceScanner(List<FileSystemInfo> files)
        {
            this.files = files;
            repo = new AuctionListItemSaleRepository();
        }

        public void EnumerateAndWriteToDB()
        {
            foreach (var file in files)
            {
                if (file.FullName.EndsWith(".json"))
                {

                }
            }
        }

                var stream = new StreamReader(path);
        var text = stream.ReadToEnd();

            if (text.Contains("Last Lot:"))
            {
                var firstSplit = text.Split(new string[] { "Last Lot:" }, StringSplitOptions.None)[1].Substring(0, 50).Trim();
        Dts.Variables["User::Text"].Value = firstSplit;
                var itemNumber = firstSplit.Split(new string[] { " " }, StringSplitOptions.None)[0];
                if (itemNumber.Length > 5 || !firstSplit.Contains("$"))
                {
                    Dts.TaskResult = (int)ScriptResults.Failure;
                    return;
                }
    var price = firstSplit.Split(new string[] { "$" }, StringSplitOptions.None)[1];
    price = price.Split(new string[] { "\\" }, StringSplitOptions.None)[0];
              //  int ItemNumber=0;
                //if (int.TryParse(a, out ItemNumber))
                    Dts.Variables["User::ItemNumber"].Value = itemNumber;
                Dts.Variables["User::ItemPrice"].Value = price;
                //else Dts.Variables["User::ItemNumber"].Value = 0;

                //var secondSplit = firstSplit.Split(new string[] { "$" }, StringSplitOptions.None)[1];
                //Dts.Variables["User::ItemPrice"].Value = secondSplit.Split(new string[] { "\\" }, StringSplitOptions.None)[0];
    }
}
