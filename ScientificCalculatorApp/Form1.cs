using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculatorApp
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        String number = "0";
        bool operation_pressed = false;
        bool equal_pressed = false;
        String answer = "";
        String memory = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            result.Text = "";
            if (number == "0" || operation_pressed)
                number = "";
            if (equal_pressed)
            {
                equation.Text = "";
                number = "";
            }                

            Button b = (Button)sender;
            equation.Text = equation.Text + b.Text;
            number = number + b.Text;
            operation_pressed = false;
            equal_pressed = false;
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            result.Text = "";
            number = "";
            operation_pressed = false;
            equal_pressed = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            result.Clear();
            value = 0;
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            equal_pressed = false;
            Button b = (Button)sender;
            if (b.Text == "EXP")
                b.Text = " x 10^";
            if (b.Text == "sin " || b.Text == "cos " || b.Text == "tan " || b.Text == "log " || b.Text == "ln " || b.Text == "√")
            {
                equation.Text = "";
                number = "0";
            }      
            operation = b.Text;
            equation.Text = equation.Text + b.Text;
            value = Double.Parse(number);
            if (b.Text == " 1/x")
                result.Text = (1/value).ToString();
            operation_pressed = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            equal_pressed = true;
            switch (operation)
            {
                case "+":
                    number = (value + Double.Parse(number)).ToString();
                    result.Text = number;
                    break;
                case "-":
                    number = (value - Double.Parse(number)).ToString();
                    result.Text = number;
                    break;
                case "x":
                    number = (value * Double.Parse(number)).ToString();
                    result.Text = number;
                    break;
                case "÷":
                    number = (value / Double.Parse(number)).ToString();
                    result.Text = number;
                    break;
                case " x 10^":
                    number = (value * Math.Pow(10,Double.Parse(number))).ToString();
                    result.Text = number;
                    break;
                case "sin ":
                    number = (Math.Round((Math.Sin(Double.Parse(number) * Math.PI / 180)), 10)).ToString();
                    result.Text = number;
                    break;
                case "cos ":
                    number = (Math.Round((Math.Cos(Double.Parse(number) * Math.PI / 180)),10)).ToString();
                    result.Text = number;
                    break;
                case "tan ":
                    number = (Math.Round((Math.Tan(Double.Parse(number) * Math.PI / 180)), 10)).ToString();
                    result.Text = number;
                    break;
                case "log ":
                    number = (Math.Round(Math.Log10(Double.Parse(number)), 10)).ToString();
                    result.Text = number;
                    break;
                case "ln ":
                    number = (Math.Round(Math.Log(Double.Parse(number),Math.E), 9)).ToString();
                    result.Text = number;
                    break;
                case "²":
                    number = (Math.Pow(value,2)).ToString();
                    result.Text = number;
                    break;
                case "^":
                    number = (Math.Pow(value, Double.Parse(number))).ToString();
                    result.Text = number;
                    break;
                case "√":
                    number = (Math.Round(Math.Sqrt(Double.Parse(number)),9)).ToString();
                    result.Text = number;
                    break;
                case " BIN":
                    number = (Convert.ToString(int.Parse(number), 2)).ToString();
                    result.Text = number;
                    break;
                case " HEX":
                    number = (Convert.ToString(int.Parse(number), 16)).ToString();
                    result.Text = number;
                    break;
                default:
                    break;
            }
            answer = result.Text;
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            equation.Text = equation.Text + b.Text;            
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            memory += result.Text; 
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBracket_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            equation.Text = equation.Text + b.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
