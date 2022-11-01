using BackCalculator;
using System;
using System.Windows.Forms;

namespace FrontCalculator
{
    public partial class Calculadora : Form // MaterialForm
    {

        readonly ICalculator oneCalculator;

        Double firstValue = 0;
        Double secondValue = 0;
        Double total = 0;
        String operation = "";
        bool operationPressed = false;

        public Calculadora(ICalculator oneCalculator)
        {
            this.oneCalculator = oneCalculator;
            InitializeComponent();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            equation2.Text = "";
            secondValue = Double.Parse(displayNum.Text);

            if (operation.Equals("/"))
                total = oneCalculator.Divide(firstValue, secondValue);
            if (operation.Equals("x"))
                total = oneCalculator.Multiply(firstValue, secondValue);
            if (operation.Equals("+"))
                total = oneCalculator.Sum(firstValue, secondValue);
            if (operation.Equals("-"))
                total = oneCalculator.Subtracts(firstValue, secondValue);

            displayNum.Text = total.ToString();

            Console.WriteLine("first value: " + firstValue);
            Console.WriteLine("second value: " + secondValue);
            Console.WriteLine("total: " + total);
            Console.WriteLine("operation: " + operation);
            Console.WriteLine("operationPressed: " + operationPressed);

        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                displayNum.Clear();
            }

            operationPressed = false;

            Button aButton = (Button)sender;
            displayNum.Text += aButton.Text;

        }

        private void OperatorsExtra(object sender, EventArgs e)
        {
            if (operation.Equals("1/x"))
                total = oneCalculator.DivideByItself(firstValue);
            if (operation.Equals("x^2"))
                total = oneCalculator.Squared(Int32.Parse(firstValue.ToString()));
            if (operation.Equals("_/x"))
                total = oneCalculator.SquaredRoot(firstValue);

            displayNum.Text = total.ToString();
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button aButton = (Button)sender;
            operation = aButton.Text;
            operationPressed = true;

            firstValue = Double.Parse(displayNum.Text);

            OperatorsExtra(sender, e);
            equation2.Text = firstValue + " " + operation;
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult optionResult = MessageBox.Show("Desea salir ? ", "Confirmación", botones, MessageBoxIcon.Question);

            if (optionResult == DialogResult.No)
                e.Cancel = true;
        }

        private void OperationClear(object sender, EventArgs e)
        {
            Button aButton = (Button)sender;
            operation = aButton.Text;

            if (operation == "CE") 
            {
                displayNum.Text = "0";
                firstValue = 0;
            }

            displayNum.Text = "0";

        }

        private void RemoveValue(object sender, EventArgs e)
        {
            if (displayNum.Text.Length != 0)
                displayNum.Text = displayNum.Text.Remove(displayNum.Text.Length - 1);
        }

    }
}
