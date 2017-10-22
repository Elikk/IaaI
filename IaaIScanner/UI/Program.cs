using IaaIScanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir;
            Console.WriteLine("EnterDirectoryToScan");
            dir = Console.ReadLine();

            var files = new SourceFiles(dir);

            var a = new PhotoScanner(files.FileList);
            a.EnumerateAndWriteToDB();
        }
    }
}
