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
    public partial class Übung1 : Form
    {
        public Übung1()
        {
            InitializeComponent();
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            LblShow.Text = "+";
        }

        private void CmdMinus_Click(object sender, EventArgs e)
        {
            LblShow.Text = "-";
        }
    }
}
