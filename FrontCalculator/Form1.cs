using BackCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCalculator
{
    public partial class Calculadora : Form
    {
        readonly ICalculator oneCalculator = new Calculator();

        Double value = 0;
        String operation = "";
        bool operationPressed = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayNum.Text = "0";
            value = 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            displayNum.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            if (operation == "/")
                displayNum.Text = oneCalculator.dividir(value, Double.Parse(displayNum.Text)).ToString();
            if (operation == "x")
                displayNum.Text = oneCalculator.multiply(value, Double.Parse(displayNum.Text)).ToString();
            if (operation == "+")
                displayNum.Text = oneCalculator.sum(value, Double.Parse(displayNum.Text)).ToString();
            if (operation == "-")
                displayNum.Text = oneCalculator.subtracts(value, Double.Parse(displayNum.Text)).ToString();

        }

        private void coma_Click(object sender, EventArgs e)
        {

        }

        private void displayNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if ((displayNum.Text == "0") || (operationPressed))
                displayNum.Clear();
            
            operationPressed = false;

            Button aButton = (Button)sender;
            displayNum.Text = displayNum.Text + aButton.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button aButton = (Button)sender;
            operation = aButton.Text;
            value = Double.Parse(displayNum.Text);
            operationPressed = true;

            equation.Text = value + " " + operation;
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult optionResult = MessageBox.Show("Desea salir ? ", "Confirmación", botones, MessageBoxIcon.Question);

            if (optionResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}
