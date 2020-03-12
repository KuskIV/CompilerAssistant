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
            this.CommandPromt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 921);
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
            this.PowerShellTxt.Location = new System.Drawing.Point(12, 57);
            this.PowerShellTxt.Multiline = true;
            this.PowerShellTxt.Name = "PowerShellTxt";
            this.PowerShellTxt.ReadOnly = true;
            this.PowerShellTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PowerShellTxt.Size = new System.Drawing.Size(1341, 861);
            this.PowerShellTxt.TabIndex = 1;
            this.PowerShellTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CompileBtn
            // 
            this.CompileBtn.Location = new System.Drawing.Point(12, 12);
            this.CompileBtn.Name = "CompileBtn";
            this.CompileBtn.Size = new System.Drawing.Size(201, 39);
            this.CompileBtn.TabIndex = 2;
            this.CompileBtn.Text = "Compile";
            this.CompileBtn.UseVisualStyleBackColor = true;
            this.CompileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommandPromt
            // 
            this.CommandPromt.Location = new System.Drawing.Point(219, 12);
            this.CommandPromt.Multiline = true;
            this.CommandPromt.Name = "CommandPromt";
            this.CommandPromt.Size = new System.Drawing.Size(1134, 39);
            this.CommandPromt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1365, 955);
            this.Controls.Add(this.CommandPromt);
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
        private System.Windows.Forms.TextBox CommandPromt;
    }
}

