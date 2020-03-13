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

        public string Replace(string source, string destination)
        {
            return EmptyDestination(destination) + "\r\n" + FillDestination(source, destination);
        }

        string FillDestination(string source, string destination)
        {
            DirectoryInfo dir = new DirectoryInfo(source);

            if (dir.Exists)
            {
                try
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
                catch (Exception e)
                {
                    return e.ToString();
                }
                
            }
            else
            {
                return $"The following path was not found:\n{source} (Folder.FillDestination())";
            }

            return "";
        }

        public string Clear(string source)
        {
            return EmptySourse(source);
        }

        #region private methods
        string EmptySourse(string source)
        {
            return DeleteFolders(source);
        }

        string EmptyDestination(string destination)
        {
            string path = destination + @"\company";
            try
            {
                if (PathExists(path))
                {
                    DeleteFiles(path + @"\analysis");
                    DeleteFiles(path + @"\lexer");
                    DeleteFiles(path + @"\node");
                    DeleteFiles(path + @"\parser");
                }
                else
                {
                    return "Path did not exist (EmptyDestination())\r\n" + path;
                }
            }
            catch (Exception e)
            {
                return "DESTINATION COULD NOT BE DELETED (Folder.EmptyDestination())\r\n" + e.ToString();
            }
            return "";
        }

        bool PathExists(string path)
        {
            return new DirectoryInfo(path).Exists;
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

        string DeleteFolders(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                try
                {
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
                catch (Exception e)
                {
                    return "FOLDERS COULD NOT BE DELETED (check start path, Folder.DeleteFolders())\r\n" + e.ToString();
                }
            }

            return "";
        }
        #endregion
    }
}
