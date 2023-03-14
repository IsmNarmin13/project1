using MathFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathFunctions;

namespace ProjectForOurUniversity
{
    public partial class Form1 : Form
    {
        static List<string> functions = new List<string>
        {
            new string("x^2 + 4"),
            new string("x - 4"),
            new string("sinx")
        };

        public Form1()
        {
            InitializeComponent();
            functionsComboBox.DataSource = functions;
            functionsComboBox.SelectedItem = null;
        }

        private void findRootOfTheEquationButton_Click(object sender, EventArgs e)
        {
            if (AValueTextBox.Text != String.Empty
                && BValueTextBox.Text != String.Empty
                && EpsValueTextBox.Text != String.Empty)
                switch (functionsComboBox.SelectedIndex)
                {
                    case 0:
                        Func<double, double> equation = (x) => x * x + 4;
                        double result = Math_Functions.BisectionMethod(equation, Convert.ToDouble(AValueTextBox.Text), Convert.ToDouble(BValueTextBox.Text), Convert.ToDouble(EpsValueTextBox.Text));
                        resultTextBox.Text = $"{result}";
                        break;
                }
        }
    }
}
