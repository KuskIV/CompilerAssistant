using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace SableCC_CompilerAssisten
{
    class Compile
    {
        public Compile(string _command, string _path)
        {
            path = _path;
            command = _command;
        }
        public Compile() { }

        string command, path;
        StringBuilder stringBuilder = new StringBuilder();


        public bool run()
        {
            bool result = true;

            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                runspace.Open();
                runspace.SessionStateProxy.Path.SetLocation(path);
                using (Pipeline pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.Add(command);
                    Collection<PSObject> pSObjects = pipeline.Invoke();

                    if (pipeline.HadErrors)
                    {
                        result = false;
                        var errors = pipeline.Error.ReadToEnd();
                        PrintErrors(errors);
                    }
                }
                runspace.Close();
            }

            return result;
        }

        public string Run(string command, string path, out bool isErrors)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            runspace.SessionStateProxy.Path.SetLocation(path);

            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.Add(command);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> pSObjects = pipeline.Invoke();
            //PrintMessage(pSObjects);
            if (pipeline.HadErrors)
            {
                isErrors = true;
                var errors = pipeline.Error.ReadToEnd();
                PrintErrors(errors);
            }
            else
            {
                isErrors = false;
            }
            runspace.Close();
            string s = stringBuilder.ToString();
            return stringBuilder.ToString();
        }

        void PrintErrors(Collection<object> errors)
        {
            foreach (var error in errors)
            {
                stringBuilder.AppendLine(error.ToString());
            }
        }

        void PrintMessage(Collection<PSObject> psObj)
        {
            foreach (var obj in psObj)
            {
                stringBuilder.AppendLine(obj.ToString());
            }
        }
    }
}
