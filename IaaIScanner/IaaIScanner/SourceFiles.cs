using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaaIScanner
{
    public class SourceFiles
    {
        private string directory;
        public List<FileSystemInfo> FileList;

        public SourceFiles(string directory)
        {
            this.directory = directory;
            EnumerateFilesAndSort();
        }

        private void EnumerateFilesAndSort()
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            FileList = files.OrderBy(f => f.CreationTime).ToList();
        }


        


    }
}
