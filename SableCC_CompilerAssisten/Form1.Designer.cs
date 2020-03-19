namespace SableCC_CompilerAssisten
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PowerShellTxt = new System.Windows.Forms.TextBox();
            this.CompileBtn = new System.Windows.Forms.Button();
            this.Commandtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pathtxt = new System.Windows.Forms.TextBox();
            this.SetScriptBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AllErrors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 921);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This application is approved by JAMR";
            // 
            // PowerShellTxt
            // 
            this.PowerShellTxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.PowerShellTxt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerShellTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.PowerShellTxt.Location = new System.Drawing.Point(12, 105);
            this.PowerShellTxt.Multiline = true;
            this.PowerShellTxt.Name = "PowerShellTxt";
            this.PowerShellTxt.ReadOnly = true;
            this.PowerShellTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PowerShellTxt.Size = new System.Drawing.Size(1180, 813);
            this.PowerShellTxt.TabIndex = 1;
            this.PowerShellTxt.WordWrap = false;
            // 
            // CompileBtn
            // 
            this.CompileBtn.Location = new System.Drawing.Point(1068, 12);
            this.CompileBtn.Name = "CompileBtn";
            this.CompileBtn.Size = new System.Drawing.Size(124, 87);
            this.CompileBtn.TabIndex = 2;
            this.CompileBtn.Text = "Compile";
            this.CompileBtn.UseVisualStyleBackColor = true;
            this.CompileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commandtxt
            // 
            this.Commandtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commandtxt.Location = new System.Drawing.Point(80, 12);
            this.Commandtxt.Multiline = true;
            this.Commandtxt.Name = "Commandtxt";
            this.Commandtxt.Size = new System.Drawing.Size(839, 39);
            this.Commandtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Script";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path";
            // 
            // Pathtxt
            // 
            this.Pathtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pathtxt.Location = new System.Drawing.Point(80, 60);
            this.Pathtxt.Multiline = true;
            this.Pathtxt.Name = "Pathtxt";
            this.Pathtxt.Size = new System.Drawing.Size(839, 39);
            this.Pathtxt.TabIndex = 6;
            // 
            // SetScriptBtn
            // 
            this.SetScriptBtn.Location = new System.Drawing.Point(925, 12);
            this.SetScriptBtn.Name = "SetScriptBtn";
            this.SetScriptBtn.Size = new System.Drawing.Size(137, 39);
            this.SetScriptBtn.TabIndex = 7;
            this.SetScriptBtn.Text = "Reset Script";
            this.SetScriptBtn.UseVisualStyleBackColor = true;
            this.SetScriptBtn.Click += new System.EventHandler(this.SetScriptBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AllErrors
            // 
            this.AllErrors.AutoSize = true;
            this.AllErrors.Location = new System.Drawing.Point(17, 924);
            this.AllErrors.Name = "AllErrors";
            this.AllErrors.Size = new System.Drawing.Size(239, 29);
            this.AllErrors.TabIndex = 9;
            this.AllErrors.Text = "Show all errors (BETA)";
            this.AllErrors.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AllErrors.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1204, 960);
            this.Controls.Add(this.AllErrors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SetScriptBtn);
            this.Controls.Add(this.Pathtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Commandtxt);
            this.Controls.Add(this.CompileBtn);
            this.Controls.Add(this.PowerShellTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SableCC Compiler Assistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PowerShellTxt;
        private System.Windows.Forms.Button CompileBtn;
        private System.Windows.Forms.TextBox Commandtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pathtxt;
        private System.Windows.Forms.Button SetScriptBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox AllErrors;
    }
}

