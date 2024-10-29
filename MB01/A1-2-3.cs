using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void BtnRauf_Click(object sender, EventArgs e)
        {
            BtnFläche.Location = new Point(BtnFläche.Location.X, BtnFläche.Location.Y - 10);
        }

        private void BtnRechts_Click(object sender, EventArgs e)
        {
            BtnFläche.Location = new Point(BtnFläche.Location.X + 10, BtnFläche.Location.Y);
        }

        private void BtnLinks_Click(object sender, EventArgs e)
        {
            BtnFläche.Location = new Point(BtnFläche.Location.X - 10, BtnFläche.Location.Y);
        }

        private void BtnRunter_Click(object sender, EventArgs e)
        {
            BtnFläche.Location = new Point(BtnFläche.Location.X, BtnFläche.Location.Y + 10);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            BtnFläche.Location = new Point(387, 330);
        }
    }
}
