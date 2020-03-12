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
            this.PowerShellTxt.Location = new System.Drawing.Point(12, 105);
            this.PowerShellTxt.Multiline = true;
            this.PowerShellTxt.Name = "PowerShellTxt";
            this.PowerShellTxt.ReadOnly = true;
            this.PowerShellTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PowerShellTxt.Size = new System.Drawing.Size(1114, 813);
            this.PowerShellTxt.TabIndex = 1;
            // 
            // CompileBtn
            // 
            this.CompileBtn.Location = new System.Drawing.Point(926, 12);
            this.CompileBtn.Name = "CompileBtn";
            this.CompileBtn.Size = new System.Drawing.Size(201, 87);
            this.CompileBtn.TabIndex = 2;
            this.CompileBtn.Text = "Compile";
            this.CompileBtn.UseVisualStyleBackColor = true;
            this.CompileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commandtxt
            // 
            this.Commandtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commandtxt.Location = new System.Drawing.Point(132, 12);
            this.Commandtxt.Multiline = true;
            this.Commandtxt.Name = "Commandtxt";
            this.Commandtxt.ReadOnly = true;
            this.Commandtxt.Size = new System.Drawing.Size(787, 39);
            this.Commandtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command";
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
            this.Pathtxt.Location = new System.Drawing.Point(132, 60);
            this.Pathtxt.Multiline = true;
            this.Pathtxt.Name = "Pathtxt";
            this.Pathtxt.ReadOnly = true;
            this.Pathtxt.Size = new System.Drawing.Size(787, 39);
            this.Pathtxt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1139, 955);
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
    }
}

