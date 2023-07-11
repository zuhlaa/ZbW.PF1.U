using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A4_1
{
    public partial class A4_1_4 : Form
    {
        public A4_1_4()
        {
            InitializeComponent();
        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TxtValue1.Text);
            int b = Convert.ToInt32(TxtValue2.Text);
            string text = "";

            if(a == b)
            {
                text = "A und B sind gleich gross";
            }
            else if (a > b)
            {
                text = "A ist grösser!";
            }
            else
            {
                text = "B ist grösser!";
            }

            LblResult.Text = text;
        }
    }
}
