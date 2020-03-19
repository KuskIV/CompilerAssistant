using Markdig.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace SableCC_CompilerAssisten
{
    class Compile
    {
        StringBuilder stringBuilder = new StringBuilder();
        Script script;

        string libFolder = "lib";
        string sablecc = "sablecc.jar";
        string bat = "sablecc.bat";
        string iml = "SableCC_V3.iml";
        string sableFile;
        List<string> files;



        /// <summary>
        /// Runs the script in command, and returns the last message.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="path"></param>
        /// <param name="isErrors"></param>
        /// <returns></returns>
        public string Run(string command, string path, bool ReturAllErrors, out bool isErrors, out bool isSable)
        {
            string error = SetupScript(command, path);
            isErrors = false;

            if (!String.IsNullOrEmpty(error))
            {
                isErrors = true;
                isSable = false;
                return error;
            }

            try
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                runspace.SessionStateProxy.Path.SetLocation(path);

                Pipeline pipeline = runspace.CreatePipeline();
                pipeline.Commands.Add(command);
                pipeline.Commands.Add("Out-String");
                Collection<PSObject> pSObjects = pipeline.Invoke();
                if (pipeline.HadErrors)
                {
                    isErrors = true;
                    var errors = pipeline.Error.ReadToEnd();
                    PrintErrors(errors);
                }
                else
                {
                    PrintMessage(pSObjects);
                }

                runspace.Close();
            }
            catch (Exception e)
            {
                isErrors = true;
                error = "THE COMPILER COULD NOT RUN (Compiler.Run())\r\n" + e.ToString();
            }

            isSable = script != null ? SableComand(command) : false;

            return String.IsNullOrEmpty(stringBuilder.ToString()) ? error : isErrors ? ReturnErrors(command, ReturAllErrors) : stringBuilder.ToString();
        }

        #region private methods
        /// <summary>
        /// When recompiling, the errors from all other compiles are also included.
        /// This method finds and returns the most recent.
        /// </summary>
        /// <param name="messages"></param>
        /// <returns></returns>
        string GetLastError(string messages)
        {
            List<string> lines = messages.Split(new[] { "\r\n" }, StringSplitOptions.None ).ToList();
            lines = lines.Where( x => !String.IsNullOrEmpty(x)).ToList();

            return GetLastMessage(lines);
        }

        /// <summary>
        /// This method splits the different messages and returns the last.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        string GetLastMessage(List<string> lines)
        {
            string result = "";

            if (lines.Count != 0)
            {
                foreach (string line in lines)
                {
                    if (result == "")
                    {
                        result = line + "\r\n";
                    }
                    else if (line[0] == ' ' || line[0] == '\t')
                    {
                        result += line + "\r\n";
                    }
                    else
                    {
                        result = line + "\r\n";
                    }
                }
            }

            return result;
        }

        void PrintErrors(Collection<object> errors)
        {
            stringBuilder.Clear();

            foreach (var error in errors)
            {
                stringBuilder.AppendLine(error.ToString());
            }
        }

        void PrintMessage(Collection<PSObject> psObj)
        {
            stringBuilder.Clear();

            foreach (var obj in psObj)
            {
                stringBuilder.AppendLine(obj.ToString());
            }
        }

        string ReturnErrors(string command, bool returnAll)
        {
            if (script != null)
            {
                if (SableComand(command) && !returnAll)
                {
                    return GetLastError(stringBuilder.ToString());
                }
            }
            return stringBuilder.ToString();
        }

        bool SableComand(string path)
        {
            return script.get().Contains(@".\sablecc");
        }

        bool PathExists(string path)
        {
            return new DirectoryInfo(path).Exists;
        }
        
        string SetupScript(string command, string path)
        {
            if (File.Exists(command))
            {
                script = new Script(command);

                sableFile = script.get().Split(' ')[1];
                if (SableComand(command))
                {
                    return VerifyFiles(path);
                }
                else
                {
                    return "";
                }
            }

            return "The path:\r\n" + command + "\r\nDoes not lead to a .ps1 file, and can therefore not be run.";
        }

        string VerifyFiles(string path)
        {
            SetupFilelist();
            string result = "";

            foreach (string file in files)
            {
                if (!File.Exists(path + @"\" + file))
                {
                    if (String.IsNullOrEmpty(result))
                    {
                        result = "In path:\r\n" + path + "\r\n\r\nThe following files are missing to run SableCC\r\n" + file;
                    }
                    else
                    {
                        result += "\t - " + file + "\r\n";
                    }
                }
            }

            return result;
        }

        void SetupFilelist()
        {
            files = new List<string>() { libFolder + @"\" + sablecc, bat, iml, sableFile };
        }
        #endregion
    }
}
