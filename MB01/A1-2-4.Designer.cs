namespace MB01
{
    partial class Form5
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
            CmdHöheGrösser = new Button();
            CmdHöheKleiner = new Button();
            CmdbreiteGrösser = new Button();
            CmdBreiteKleiner = new Button();
            LblPos = new Label();
            LblDim = new Label();
            SuspendLayout();
            // 
            // CmdHöheGrösser
            // 
            CmdHöheGrösser.Location = new Point(212, 100);
            CmdHöheGrösser.Name = "CmdHöheGrösser";
            CmdHöheGrösser.Size = new Size(151, 23);
            CmdHöheGrösser.TabIndex = 0;
            CmdHöheGrösser.Text = "Fensterhöhe vergrössern";
            CmdHöheGrösser.UseVisualStyleBackColor = true;
            CmdHöheGrösser.Click += CmdHöheGrösser_Click;
            // 
            // CmdHöheKleiner
            // 
            CmdHöheKleiner.Location = new Point(212, 138);
            CmdHöheKleiner.Name = "CmdHöheKleiner";
            CmdHöheKleiner.Size = new Size(151, 23);
            CmdHöheKleiner.TabIndex = 1;
            CmdHöheKleiner.Text = "Fensterhöhe verkleinern";
            CmdHöheKleiner.UseVisualStyleBackColor = true;
            CmdHöheKleiner.Click += CmdHöheKleiner_Click;
            // 
            // CmdbreiteGrösser
            // 
            CmdbreiteGrösser.Location = new Point(212, 182);
            CmdbreiteGrösser.Name = "CmdbreiteGrösser";
            CmdbreiteGrösser.Size = new Size(151, 23);
            CmdbreiteGrösser.TabIndex = 2;
            CmdbreiteGrösser.Text = "Fensterbreite vergrössern";
            CmdbreiteGrösser.UseVisualStyleBackColor = true;
            CmdbreiteGrösser.Click += CmdbreiteGrösser_Click;
            // 
            // CmdBreiteKleiner
            // 
            CmdBreiteKleiner.Location = new Point(212, 221);
            CmdBreiteKleiner.Name = "CmdBreiteKleiner";
            CmdBreiteKleiner.Size = new Size(151, 23);
            CmdBreiteKleiner.TabIndex = 3;
            CmdBreiteKleiner.Text = "Fensterbreite verkleinern";
            CmdBreiteKleiner.UseVisualStyleBackColor = true;
            CmdBreiteKleiner.Click += CmdBreiteKleiner_Click;
            // 
            // LblPos
            // 
            LblPos.AutoSize = true;
            LblPos.Location = new Point(166, 309);
            LblPos.Name = "LblPos";
            LblPos.Size = new Size(53, 15);
            LblPos.TabIndex = 4;
            LblPos.Text = "Position:";
            // 
            // LblDim
            // 
            LblDim.AutoSize = true;
            LblDim.Location = new Point(317, 309);
            LblDim.Name = "LblDim";
            LblDim.Size = new Size(67, 15);
            LblDim.TabIndex = 5;
            LblDim.Text = "Dimension:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(LblDim);
            Controls.Add(LblPos);
            Controls.Add(CmdBreiteKleiner);
            Controls.Add(CmdbreiteGrösser);
            Controls.Add(CmdHöheKleiner);
            Controls.Add(CmdHöheGrösser);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdHöheGrösser;
        private Button CmdHöheKleiner;
        private Button CmdbreiteGrösser;
        private Button CmdBreiteKleiner;
        private Label LblPos;
        private Label LblDim;
    }
}