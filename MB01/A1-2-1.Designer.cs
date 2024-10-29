namespace MB01
{
    partial class Form2
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
            BtnGelb = new Button();
            BtnRot = new Button();
            BtnGrün = new Button();
            BtnBlau = new Button();
            LblGelb = new Label();
            LblRot = new Label();
            LblGrün = new Label();
            LblBlau = new Label();
            SuspendLayout();
            // 
            // BtnGelb
            // 
            BtnGelb.Location = new Point(98, 59);
            BtnGelb.Name = "BtnGelb";
            BtnGelb.Size = new Size(75, 23);
            BtnGelb.TabIndex = 0;
            BtnGelb.Text = "Gelb";
            BtnGelb.UseVisualStyleBackColor = true;
            BtnGelb.Click += BtnGelb_Click;
            // 
            // BtnRot
            // 
            BtnRot.Location = new Point(98, 101);
            BtnRot.Name = "BtnRot";
            BtnRot.Size = new Size(75, 23);
            BtnRot.TabIndex = 1;
            BtnRot.Text = "Rot";
            BtnRot.UseVisualStyleBackColor = true;
            BtnRot.Click += BtnRot_Click;
            // 
            // BtnGrün
            // 
            BtnGrün.Location = new Point(98, 147);
            BtnGrün.Name = "BtnGrün";
            BtnGrün.Size = new Size(75, 23);
            BtnGrün.TabIndex = 2;
            BtnGrün.Text = "Grün";
            BtnGrün.UseVisualStyleBackColor = true;
            BtnGrün.Click += BtnGrün_Click;
            // 
            // BtnBlau
            // 
            BtnBlau.Location = new Point(98, 192);
            BtnBlau.Name = "BtnBlau";
            BtnBlau.Size = new Size(75, 23);
            BtnBlau.TabIndex = 3;
            BtnBlau.Text = "Blau";
            BtnBlau.UseVisualStyleBackColor = true;
            BtnBlau.Click += BtnBlau_Click;
            // 
            // LblGelb
            // 
            LblGelb.AutoSize = true;
            LblGelb.Location = new Point(216, 62);
            LblGelb.Name = "LblGelb";
            LblGelb.Size = new Size(0, 15);
            LblGelb.TabIndex = 4;
            // 
            // LblRot
            // 
            LblRot.AutoSize = true;
            LblRot.Location = new Point(216, 105);
            LblRot.Name = "LblRot";
            LblRot.Size = new Size(0, 15);
            LblRot.TabIndex = 5;
            // 
            // LblGrün
            // 
            LblGrün.AutoSize = true;
            LblGrün.Location = new Point(216, 151);
            LblGrün.Name = "LblGrün";
            LblGrün.Size = new Size(0, 15);
            LblGrün.TabIndex = 6;
            // 
            // LblBlau
            // 
            LblBlau.AutoSize = true;
            LblBlau.Location = new Point(216, 196);
            LblBlau.Name = "LblBlau";
            LblBlau.Size = new Size(0, 15);
            LblBlau.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblBlau);
            Controls.Add(LblGrün);
            Controls.Add(LblRot);
            Controls.Add(LblGelb);
            Controls.Add(BtnBlau);
            Controls.Add(BtnGrün);
            Controls.Add(BtnRot);
            Controls.Add(BtnGelb);
            Name = "Form2";
            Text = "A1-2-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGelb;
        private Button BtnRot;
        private Button BtnGrün;
        private Button BtnBlau;
        private Label LblGelb;
        private Label LblRot;
        private Label LblGrün;
        private Label LblBlau;
    }
}