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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void CmdHöheGrösser_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height + 10);
            LblPos.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDim.Text = "Breite: X; " + Size.Width + ", Y: " + Size.Height;
        }

        private void CmdHöheKleiner_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height - 10);
            LblPos.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDim.Text = "Breite: X; " + Size.Width + ", Y: " + Size.Height;
        }

        private void CmdbreiteGrösser_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width + 10, Size.Height);
            LblPos.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDim.Text = "Breite: X; " + Size.Width + ", Y: " + Size.Height;
        }

        private void CmdBreiteKleiner_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width - 10, Size.Height);
            LblPos.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDim.Text = "Breite: X; " +Size.Width + ", Y: " + Size.Height;
        }


    }
}
