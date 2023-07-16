namespace MB06.A13_1_1
{
    partial class MathView
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
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdSub = new System.Windows.Forms.Button();
            this.CmdMult = new System.Windows.Forms.Button();
            this.CmdDiv = new System.Windows.Forms.Button();
            this.TxtResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtValue1
            // 
            this.TxtValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue1.Location = new System.Drawing.Point(194, 62);
            this.TxtValue1.Margin = new System.Windows.Forms.Padding(6);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(250, 50);
            this.TxtValue1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Wert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Wert:";
            // 
            // TxtValue2
            // 
            this.TxtValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue2.Location = new System.Drawing.Point(194, 135);
            this.TxtValue2.Margin = new System.Windows.Forms.Padding(6);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(250, 50);
            this.TxtValue2.TabIndex = 2;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.Location = new System.Drawing.Point(36, 224);
            this.CmdAdd.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(84, 65);
            this.CmdAdd.TabIndex = 4;
            this.CmdAdd.Tag = "Add";
            this.CmdAdd.Text = "+";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.Calc_Click);
            // 
            // CmdSub
            // 
            this.CmdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSub.Location = new System.Drawing.Point(142, 224);
            this.CmdSub.Margin = new System.Windows.Forms.Padding(6);
            this.CmdSub.Name = "CmdSub";
            this.CmdSub.Size = new System.Drawing.Size(84, 65);
            this.CmdSub.TabIndex = 5;
            this.CmdSub.Tag = "Sub";
            this.CmdSub.Text = "-";
            this.CmdSub.UseVisualStyleBackColor = true;
            this.CmdSub.Click += new System.EventHandler(this.Calc_Click);
            // 
            // CmdMult
            // 
            this.CmdMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMult.Location = new System.Drawing.Point(251, 224);
            this.CmdMult.Margin = new System.Windows.Forms.Padding(6);
            this.CmdMult.Name = "CmdMult";
            this.CmdMult.Size = new System.Drawing.Size(84, 65);
            this.CmdMult.TabIndex = 6;
            this.CmdMult.Tag = "Mult";
            this.CmdMult.Text = "x";
            this.CmdMult.UseVisualStyleBackColor = true;
            this.CmdMult.Click += new System.EventHandler(this.Calc_Click);
            // 
            // CmdDiv
            // 
            this.CmdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDiv.Location = new System.Drawing.Point(360, 224);
            this.CmdDiv.Margin = new System.Windows.Forms.Padding(6);
            this.CmdDiv.Name = "CmdDiv";
            this.CmdDiv.Size = new System.Drawing.Size(84, 65);
            this.CmdDiv.TabIndex = 7;
            this.CmdDiv.Tag = "Div";
            this.CmdDiv.Text = "/";
            this.CmdDiv.UseVisualStyleBackColor = true;
            this.CmdDiv.Click += new System.EventHandler(this.Calc_Click);
            // 
            // TxtResults
            // 
            this.TxtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResults.Location = new System.Drawing.Point(484, 62);
            this.TxtResults.Margin = new System.Windows.Forms.Padding(6);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResults.Size = new System.Drawing.Size(470, 313);
            this.TxtResults.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 65);
            this.button1.TabIndex = 9;
            this.button1.Tag = "Sqrt";
            this.button1.Text = "Sqr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResults);
            this.Controls.Add(this.CmdDiv);
            this.Controls.Add(this.CmdMult);
            this.Controls.Add(this.CmdSub);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValue1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Analyseaufgabe_A13-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdSub;
        private System.Windows.Forms.Button CmdMult;
        private System.Windows.Forms.Button CmdDiv;
        private System.Windows.Forms.TextBox TxtResults;
        private System.Windows.Forms.Button button1;
    }
}

