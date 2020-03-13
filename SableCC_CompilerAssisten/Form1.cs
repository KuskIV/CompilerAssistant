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

        string scriptPath;
        string sourcePath;
        string destinationPath;

        string defaultScipt;
        string defaultPath;

        Folder folder = new Folder();
        Compile command = new Compile();
        Script script;

        public Form1()
        {
            InitializeComponent();
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
            scriptPath = start + @"\" + "script.ps1";
            sourcePath = start + @"\com";
            destinationPath = start + @"\src\com";

            script = new Script(scriptPath);

            defaultPath = start;
            defaultScipt = script.get();
        }

        bool PathExists()
        {
            return new DirectoryInfo(Pathtxt.Text).Exists;
        }

        void HandleResult(bool isError, bool isSable, string result)
        {
            if (!isError)
            {
                PowerShellTxt.Text = "Success!\r\n" + result;

                if (isSable)
                {
                    folder.Replace(sourcePath, destinationPath);
                }
            }
            else
            {
                PowerShellTxt.Text = "Error!\r\n" + result;
                script.set(defaultScipt);
            }
        }

        void RunCompiler()
        {
            string result = "";
            bool isError;
            bool isSable;

            script.set(Commandtxt.Text);

            result = folder.Clear(sourcePath);

            if (String.IsNullOrEmpty(result))
            {
                result = command.Run(scriptPath, Pathtxt.Text, out isError, out isSable);

                HandleResult(isError, isSable, result);
            }
            else
            {
                PowerShellTxt.Text = result;
            }
        }
        #endregion
    }
}
