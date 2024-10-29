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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Lbl1.Text += ".";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Lbl1.Text += "..";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Lbl1.Text += "...";
        }
    }
}
