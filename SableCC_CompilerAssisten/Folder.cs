using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SableCC_CompilerAssisten
{
    class Folder
    {
        DirectoryInfo[] dirs;
        FileInfo[] files;

        public void Replace(string source, string destination)
        {
            DirectoryInfo dir = new DirectoryInfo(source);

            if (dir.Exists)
            {
                dirs = dir.GetDirectories();

                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destination, file.Name);
                    file.CopyTo(temppath, true);
                }

                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destination, subdir.Name);
                    Replace(subdir.FullName, temppath);
                }
            }
        }
    }
}
