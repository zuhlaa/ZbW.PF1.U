namespace MB01
{
    partial class Form4
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
            BtnRauf = new Button();
            BtnLinks = new Button();
            BtnRechts = new Button();
            BtnRunter = new Button();
            BtnHome = new Button();
            BtnFläche = new Button();
            SuspendLayout();
            // 
            // BtnRauf
            // 
            BtnRauf.Location = new Point(360, 69);
            BtnRauf.Name = "BtnRauf";
            BtnRauf.Size = new Size(75, 23);
            BtnRauf.TabIndex = 0;
            BtnRauf.Text = "rauf";
            BtnRauf.UseVisualStyleBackColor = true;
            BtnRauf.Click += BtnRauf_Click;
            // 
            // BtnLinks
            // 
            BtnLinks.Location = new Point(272, 117);
            BtnLinks.Name = "BtnLinks";
            BtnLinks.Size = new Size(75, 23);
            BtnLinks.TabIndex = 1;
            BtnLinks.Text = "links";
            BtnLinks.UseVisualStyleBackColor = true;
            BtnLinks.Click += BtnLinks_Click;
            // 
            // BtnRechts
            // 
            BtnRechts.Location = new Point(453, 117);
            BtnRechts.Name = "BtnRechts";
            BtnRechts.Size = new Size(75, 23);
            BtnRechts.TabIndex = 2;
            BtnRechts.Text = "rechts";
            BtnRechts.UseVisualStyleBackColor = true;
            BtnRechts.Click += BtnRechts_Click;
            // 
            // BtnRunter
            // 
            BtnRunter.Location = new Point(360, 168);
            BtnRunter.Name = "BtnRunter";
            BtnRunter.Size = new Size(75, 23);
            BtnRunter.TabIndex = 3;
            BtnRunter.Text = "runter";
            BtnRunter.UseVisualStyleBackColor = true;
            BtnRunter.Click += BtnRunter_Click;
            // 
            // BtnHome
            // 
            BtnHome.Location = new Point(360, 117);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(75, 23);
            BtnHome.TabIndex = 4;
            BtnHome.Text = "home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnFläche
            // 
            BtnFläche.Location = new Point(387, 330);
            BtnFläche.Name = "BtnFläche";
            BtnFläche.Size = new Size(48, 23);
            BtnFläche.TabIndex = 5;
            BtnFläche.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFläche);
            Controls.Add(BtnHome);
            Controls.Add(BtnRunter);
            Controls.Add(BtnRechts);
            Controls.Add(BtnLinks);
            Controls.Add(BtnRauf);
            Name = "Form4";
            Text = "A1-2-3";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRauf;
        private Button BtnLinks;
        private Button BtnRechts;
        private Button BtnRunter;
        private Button BtnHome;
        private Button BtnFläche;
    }
}