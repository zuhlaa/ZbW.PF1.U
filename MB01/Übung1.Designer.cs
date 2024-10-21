namespace MB01
{
    partial class Übung1
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
            CmdPlus = new Button();
            CmdMinus = new Button();
            LblShow = new Label();
            SuspendLayout();
            // 
            // CmdPlus
            // 
            CmdPlus.Location = new Point(108, 108);
            CmdPlus.Name = "CmdPlus";
            CmdPlus.Size = new Size(112, 34);
            CmdPlus.TabIndex = 0;
            CmdPlus.Text = "+";
            CmdPlus.UseVisualStyleBackColor = true;
            CmdPlus.Click += CmdPlus_Click;
            // 
            // CmdMinus
            // 
            CmdMinus.Location = new Point(108, 167);
            CmdMinus.Name = "CmdMinus";
            CmdMinus.Size = new Size(112, 34);
            CmdMinus.TabIndex = 1;
            CmdMinus.Text = "-";
            CmdMinus.UseVisualStyleBackColor = true;
            CmdMinus.Click += CmdMinus_Click;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(148, 39);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(24, 25);
            LblShow.TabIndex = 2;
            LblShow.Text = "+";
            // 
            // Übung1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblShow);
            Controls.Add(CmdMinus);
            Controls.Add(CmdPlus);
            Name = "Übung1";
            Text = "Übung1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdPlus;
        private Button CmdMinus;
        private Label LblShow;
    }
}