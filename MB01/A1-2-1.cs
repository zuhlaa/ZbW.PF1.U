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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnGelb_Click(object sender, EventArgs e)
        {
            LblGelb.Text = "Gelbe Hintergrundfarbe";
            LblGelb.BackColor = Color.Yellow;

        }

        private void BtnRot_Click(object sender, EventArgs e)
        {
            LblRot.Text = "Rote Hintergrundfarbe";
            LblRot.BackColor = Color.Red;
        }

        private void BtnGrün_Click(object sender, EventArgs e)
        {
            LblGrün.Text = "Grüne Hintergrundfarbe";
            LblGrün.BackColor = Color.Green;
        }

        private void BtnBlau_Click(object sender, EventArgs e)
        {
            LblBlau.Text = "Blau Hintergrundfarbe";
            LblBlau.BackColor = Color.Blue;
        }
    }
}
