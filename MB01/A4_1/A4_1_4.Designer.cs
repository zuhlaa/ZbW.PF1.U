namespace MB01.A4_1
{
    partial class A4_1_4
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblValue1 = new System.Windows.Forms.Label();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.CmdCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(13, 13);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(41, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "Zahl A:";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(13, 39);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(41, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "Zahl B:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(63, 13);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(162, 20);
            this.TxtValue1.TabIndex = 2;
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(63, 40);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(162, 20);
            this.TxtValue2.TabIndex = 3;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(60, 115);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(16, 13);
            this.LblResult.TabIndex = 4;
            this.LblResult.Text = "...";
            // 
            // CmdCheck
            // 
            this.CmdCheck.Location = new System.Drawing.Point(63, 67);
            this.CmdCheck.Name = "CmdCheck";
            this.CmdCheck.Size = new System.Drawing.Size(162, 23);
            this.CmdCheck.TabIndex = 5;
            this.CmdCheck.Text = "Bestimme grössere Zahl:";
            this.CmdCheck.UseVisualStyleBackColor = true;
            this.CmdCheck.Click += new System.EventHandler(this.CmdCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdCheck);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-1-6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button CmdCheck;
    }
}

