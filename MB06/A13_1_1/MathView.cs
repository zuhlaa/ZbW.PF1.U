using System;
using System.Windows.Forms;

namespace MB06.A13_1_1
{
    public partial class MathView : Form
    {
        // Dies ist die Klasse, welche Sie zu untersuchen haben,
        // also die Klasse ExMath
        private ExtMath em; // Feld 

        public MathView()
        {
            InitializeComponent();
            em = new ExtMath();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Button aktButton = (Button)sender;

            int value1 = Convert.ToInt32(TxtValue1.Text);
            int value2 = Convert.ToInt32(TxtValue2.Text);

            // In den folgenden Cases werden Methoden des Objekts em aufgerufen.
            // Sind diese Methoden in der Klasse ExtMath vorhanden?
            switch (aktButton.Tag)
            {
                case "Add":
                    PrintResult(value1, value2, em.Add(value1, value2), "+");
                    break;
                case "Sub":
                    PrintResult(value1, value2, em.Sub(value1, value2), "-");
                    break;
                case "Mult":
                    PrintResult(value1, value2, em.Mult(value1, value2), "x");
                    break;
                case "Div":
                    PrintResult(value1, value2, em.Div(value1, value2), "/");
                    break;
                case "Sqrt":
                    PrintResult(value1, value1, em.Sqrt(value1), "x");
                    break;
            }
        }

        private void PrintResult(int value1, int value2, double result, string operation)
        {
            TxtResults.Text += value1 + " " + operation + " " + value2 + " = " +
                result + "\r\n";
            TxtResults.SelectionStart = TxtResults.Text.Length;
            TxtResults.ScrollToCaret();
        }
    }
}
