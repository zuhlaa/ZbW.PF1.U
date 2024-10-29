namespace MB01
{
    partial class Form3
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
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Lbl1 = new Label();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.Location = new Point(110, 73);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 23);
            Btn1.TabIndex = 0;
            Btn1.Text = "1ner";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(221, 73);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 23);
            Btn2.TabIndex = 1;
            Btn2.Text = "2er";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(313, 73);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 23);
            Btn3.TabIndex = 2;
            Btn3.Text = "3er";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(208, 218);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(0, 15);
            Lbl1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl1);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Label Lbl1;
    }
}