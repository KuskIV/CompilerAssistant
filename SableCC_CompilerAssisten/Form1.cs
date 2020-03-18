using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SableCC_CompilerAssisten
{
    public partial class Form1 : Form
    {

        // Unique path to the SableCC git folder
        string start = @"C:\Users\madsh\OneDrive\Universitetet\Github Projects\SableCC";
        string extention = "";
        string ps1 = @"\script.ps1";

        string scriptPath;
        string sourcePath;
        string destinationPath;

        string defaultScipt;
        string defaultPath;

        Folder folder = new Folder();
        Compile command = new Compile();
        Script script;
        Art art = new Art();

        public Form1()
        {
            scriptPath = start + extention + ps1;

            InitializeComponent();
            SetInitialPaths();
            SetDefaultValues();

            Pathtxt.Text = start;
            Commandtxt.Text = defaultScipt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerShellTxt.Clear();

            if (PathExists())
            {
                RunCompiler();
            }
            else
            {
                PowerShellTxt.Text = "The following input path does not exist:\r\n" + Pathtxt.Text;
            }

        }

        private void SetScriptBtn_Click(object sender, EventArgs e)
        {
            Commandtxt.Text = defaultScipt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pathtxt.Text = defaultPath;
        }

        #region Private methods
        void SetDefaultValues()
        {
            script = new Script(scriptPath);

            defaultPath = start;
            defaultScipt = script.get();
        }

        void SetInitialPaths()
        {
            scriptPath = start + extention + ps1;
            sourcePath = start + @"\com";
            destinationPath = start + @"\src\com";

        }

        void SetPaths(string initial)
        {
            //scriptPath = initial + @"\SableCompilerFiles\script.ps1";
            sourcePath = initial + @"\SableCompilerFiles\com";
            destinationPath = initial + @"\src\com";

        }

        bool PathExists()
        {
            return new DirectoryInfo(Pathtxt.Text).Exists;
        }

        void HandleResult(bool isError, bool isSable, string result)
        {
            if (!isError)
            {
                PrintSuccess(result, isSable);

                if (isSable)
                {
                    folder.Replace(sourcePath, destinationPath);
                }
            }
            else
            {
                PrintError(result);
                script.set(defaultScipt);
            }
        }

        void RunCompiler()
        {
            string result = "";
            bool isError;
            bool isSable;

            script.set(Commandtxt.Text);
            //SetPaths(Pathtxt.Text);
            result = folder.Clear(sourcePath);

            if (String.IsNullOrEmpty(result))
            {
                result = command.Run(scriptPath, SetPath(Pathtxt.Text), out isError, out isSable);

                HandleResult(isError, isSable, result);
            }
            else
            {
                PowerShellTxt.Text = result;
            }
        }

        string SetPath(string initial)
        {
            if (initial == start)
            {
                return start + extention;
            }
            else
            {
                return initial;
            }
        }

        void PrintSuccess(string message, bool isSable)
        {
            string success = "\r\n" +
                             "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n" +
                             "%%                                  SUCCESS!                                   %%\r\n" +
                             "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n";

            PowerShellTxt.Text = isSable ? success + art.GetRandom() : success + message;
        }

        void PrintError(string message)
        {
            
            string error = "\r\n" +
                           "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ╭∩╮（︶︿︶）╭∩╮  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n" +
                           "%%         ┻━┻ ︵ ヽ(°□°ヽ)           <<<ERROR>>>            (╯°□°）╯︵ ┻━┻         %%\r\n" +
                           "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n\r\n";

            PowerShellTxt.Text = error + message;
        }

        #endregion
    }
}
