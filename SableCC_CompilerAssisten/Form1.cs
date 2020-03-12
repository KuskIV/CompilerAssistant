using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SableCC_CompilerAssisten
{
    public partial class Form1 : Form
    {
        // Unique path to the SableCC git folder
        string start = @"C:\Users\madsh\OneDrive\Universitetet\Github Projects\SableCC";

        // This is not the actual script, only for visuals.
        string script = @".\sablecc simpleAdder.sable";
        Folder folder = new Folder();
        Compile command = new Compile();

        public Form1()
        {
            InitializeComponent();
            Pathtxt.Text = start;
            Commandtxt.Text = script;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paths to folders and scripts used in the sablecc git folder. Do not change.
            string script = start + @"\" + "script.ps1";
            string source = start + @"\com";
            string destination = start + @"\src\com";

            string result = "";

            bool isError;

            PowerShellTxt.Clear();
            result = folder.Clear(source);

            if (String.IsNullOrEmpty(result))
            {
                result = command.Run(script, start, out isError);

                if (!isError)
                {
                    PowerShellTxt.Text = "Success!";
                    folder.Replace(source, destination);
                }
                else
                {
                    PowerShellTxt.Text = result;
                }
            }
            else
            {
                PowerShellTxt.Text = result;
            }
        }
    }
}
