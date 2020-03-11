﻿using Markdig.Helpers;
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
        public Compile(string _command, string _path)
        {
            path = _path;
            command = _command;
        }
        public Compile() { }

        string command, path;
        StringBuilder stringBuilder = new StringBuilder();

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
            s = GetLastError(stringBuilder.ToString());

            return GetLastError(stringBuilder.ToString());
        }

        string GetLastError(string messages)
        {
            List<string> lines = messages.Split(new[] { "\r\n" }, StringSplitOptions.None ).ToList();
            lines = lines.Where( x => !String.IsNullOrEmpty(x)).ToList();

            return GetLastMessage(lines);
        }

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
