using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;
        double result;
        string operation;
        Dictionary<string, Operation> calculateMap = new Dictionary<string, Operation>();

        public Form1()
        {
            InitializeComponent();
            calculateMap.Add("+", new Addition());
            calculateMap.Add("-", new Subtraction());
            calculateMap.Add("*", new Multiplication());
            calculateMap.Add("/", new Division());
            calculateMap.Add("%", new Percentage());
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            displayBox.Text = displayBox.Text + ".";
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
            historyDisplay.Text = "";
            firstNumber = 0;
            secondNumber = 0;
        }

        private void number_Click(object sender, EventArgs e)
        {
            if(displayBox.Text =="0" && displayBox.Text != null)
            {
                displayBox.Text = (sender as Button).Text;
            } else
            {
                displayBox.Text = displayBox.Text + (sender as Button).Text;
            }
        }

        private void operationBtn_Click(object sender, EventArgs e)
        {
            if(firstNumber == 0)
            {
                firstNumber = Convert.ToDouble(displayBox.Text);
                displayBox.Text = "0";
                operation = (sender as Button).Text;
                historyDisplay.Text = firstNumber + " " + operation;
            } else
            {
                secondNumber = Convert.ToDouble(displayBox.Text);
                historyDisplay.Text = historyDisplay.Text + " " + secondNumber;
                getResult();
                operation = (sender as Button).Text;
                historyDisplay.Text = historyDisplay.Text + " " + operation;
                displayBox.Text = "0";
            }            
        }    

        private void equalBtn_Click(object sender, EventArgs e)
        {            
            secondNumber = Convert.ToDouble(displayBox.Text);
            historyDisplay.Text = historyDisplay.Text + " " + displayBox.Text;
            getResult();            
        }

        private void getResult()
        {            
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    displayBox.Text = "Cannot divide by 0";
                }
                else
                {
                    result = calculateMap[operation].calculate(firstNumber, secondNumber);
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    secondNumber = 0;
                }
            }
            else
            {
                result = calculateMap[operation].calculate(firstNumber, secondNumber);
                displayBox.Text = Convert.ToString(result);
                firstNumber = result;
                secondNumber = 0;
            }
        }
    }
}
