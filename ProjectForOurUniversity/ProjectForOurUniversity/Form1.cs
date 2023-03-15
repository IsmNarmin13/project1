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

namespace ProjectForOurUniversity
{
    public partial class Form1 : Form
    {
        private void CalculatingRoot()
        {
            double a = function(Convert.ToDouble(AValueTextBox.Text));
            double b = function(Convert.ToDouble(BValueTextBox.Text));

            if (a * b < 0)
            {
                double result = Math_Functions.BisectionMethod(function, Convert.ToDouble(AValueTextBox.Text), Convert.ToDouble(BValueTextBox.Text), Convert.ToDouble(EpsValueTextBox.Text));
                resultTextBox.Text = $"{result}";
            }
            else
            {
                MessageBox.Show("Invalid values ");
            }
        }
        private void ClearTextBoxes()
        {
            AValueTextBox.Clear();
            BValueTextBox.Clear();
            EpsValueTextBox.Clear();
            resultTextBox.Clear();
            pointTextBox.Clear();
            ordersComboBox.SelectedItem = null;
            functionsComboBox.SelectedItem = null;
        }
        static List<string> functions = new List<string>
        {
            new string("x^2 - 4"),
            new string("x - 4"),
        };
        static List<string> orders = new List<string>
        {
            new string("1"),
            new string("2")
        };
        static Func<double, double> function;
        public Form1()
        {
            InitializeComponent();
            functionsComboBox.DataSource = functions;
            ordersComboBox.DataSource = orders;
            functionsComboBox.SelectedItem = null;
            ordersComboBox.SelectedItem = null;
            this.BackColor = Color.Violet;
        }

        private void findRootOfTheEquationButton_Click(object sender, EventArgs e)
        {
            if (AValueTextBox.Text != String.Empty
                && BValueTextBox.Text != String.Empty
                && EpsValueTextBox.Text != String.Empty)
                switch (functionsComboBox.SelectedIndex)
                {
                    case 0:
                        function = (x) => x * x - 4;
                        break;
                    case 1:
                        function = (x) => x - 4;
                        break;
                }
            CalculatingRoot();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void findDerivativeButton_Click(object sender, EventArgs e)
        {
            if (EpsValueTextBox.Text != String.Empty && ordersComboBox.SelectedItem != null && pointTextBox.Text != String.Empty)
            {
                switch (functionsComboBox.SelectedIndex)
                {
                    case 0:
                        function = (x) => x * x - 4;
                        break;
                    case 1:
                        function = (x) => x - 4;
                        break;
                }
                double result = Math_Functions.FindDerivateInPoint(Convert.ToDouble(pointTextBox.Text), Convert.ToUInt32(ordersComboBox.SelectedItem), Convert.ToDouble(EpsValueTextBox.Text), function);
                resultTextBox.Text = $"{result}";
            }
            else
            {
                MessageBox.Show("Text boxes can't be empty");
            }
        }
    }
}
