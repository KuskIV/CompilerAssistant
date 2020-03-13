using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SableCC_CompilerAssisten
{
    class Script
    {
        public Script(string _path)
        {
            path = _path;
        }

        string path;

        public string get()
        {
            return File.ReadAllText(path);
        }

        public void set(string newCommand)
        {
            File.WriteAllText(path, newCommand);
        }
    }
}
