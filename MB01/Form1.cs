namespace MB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHello_Click(object sender, EventArgs e)
        {
            // Hier wird ""Hallo" dem Lbl.Show.Text zugewiesen
            LblShow.Text = "Hallo";
        }
        
        private void CmdEnd_Click(object sender, EventArgs e)
        {
            LblShow.Text = "End";
        }
    }
}
