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
            EmptyDestination(destination);
            FillDestination(source, destination);
        }

        void FillDestination(string source, string destination)
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

        public void Clear(string source)
        {
            EmptySourse(source);
        }

        void EmptySourse(string source)
        {
            DeleteFolders(source);
        }

        void EmptyDestination(string destination)
        {
            string path = destination + @"\company";

            DeleteFiles(path + @"\analysis");
            DeleteFiles(path + @"\lexer");
            DeleteFiles(path + @"\node");
            DeleteFiles(path + @"\parser");
        }

        void DeleteFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
        }

        void DeleteFolders(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
