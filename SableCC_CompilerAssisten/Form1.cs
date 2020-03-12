﻿using System;
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
        string start = @"C:\Users\madsh\OneDrive\Universitetet\Github Projects\SableCC";
        Folder folder = new Folder();
        Compile command = new Compile();

        public Form1()
        {
            InitializeComponent();
            Pathtxt.Text = start;
            Commandtxt.Text = @".\sablecc simpleAdder.sable";
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
