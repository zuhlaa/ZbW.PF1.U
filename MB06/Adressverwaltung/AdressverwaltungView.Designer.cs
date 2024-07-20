namespace MB06.Adressverwaltung
{
    partial class AdressverwaltungView
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
            CmdCreateP=new Button();
            TxtOutputArea=new TextBox();
            SuspendLayout();
            // 
            // CmdCreateP
            // 
            CmdCreateP.Location=new Point(15, 15);
            CmdCreateP.Margin=new Padding(4, 3, 4, 3);
            CmdCreateP.Name="CmdCreateP";
            CmdCreateP.Size=new Size(153, 27);
            CmdCreateP.TabIndex=0;
            CmdCreateP.Text="Erzeuge Person";
            CmdCreateP.UseVisualStyleBackColor=true;
            CmdCreateP.Click+=CmdCreatePerson_Click;
            // 
            // TxtOutputArea
            // 
            TxtOutputArea.Location=new Point(15, 48);
            TxtOutputArea.Margin=new Padding(4, 3, 4, 3);
            TxtOutputArea.Multiline=true;
            TxtOutputArea.Name="TxtOutputArea";
            TxtOutputArea.Size=new Size(488, 268);
            TxtOutputArea.TabIndex=3;
            // 
            // AdressverwaltungView
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(518, 330);
            Controls.Add(TxtOutputArea);
            Controls.Add(CmdCreateP);
            Margin=new Padding(4, 3, 4, 3);
            Name="AdressverwaltungView";
            Text="Adressverwaltung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdCreateP;
        private TextBox TxtOutputArea;
    }
}

