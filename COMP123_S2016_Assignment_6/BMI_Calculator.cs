using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment_6
{
    public partial class BMI_Calculator : Form
    {
        public bool TextBoxFocus { get; set; }

        public string My_Height { get; set; }
        public string My_Weight { get; set; }

        public bool ActiveError { get; set; }

        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void BMI_CalculatorButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveError == false)
            {
                // create a reference to the sender object 
                // and tell c-sharp that it is a button
                Button buttonClicked = (Button)sender;

                if (String.Equals(HeightTextBox.Text, "0"))
                {
                    HeightTextBox.Clear();
                }
                if (String.Equals(WeightTextBox.Text, "0"))
                {
                    WeightTextBox.Clear();
                }

                if (TextBoxFocus == true)
                {

                    string HeightResult = HeightTextBox.Text;// read the string in the TextBox
                    HeightResult += buttonClicked.Text;// add the text of the button clicked to the currentResult
                    HeightTextBox.Text = HeightResult;// update the ResultTextBox
                    this.ActiveControl = HeightTextBox;
                }
                else if (TextBoxFocus == false)
                {

                    string WeightResult = WeightTextBox.Text;// read the string in the TextBox
                    WeightResult += buttonClicked.Text;// add the text of the button clicked to the currentResult
                    WeightTextBox.Text = WeightResult;// update the ResultTextBox
                    this.ActiveControl = WeightTextBox;
                }
            }


                
            
        }

        private void BMI_Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxFocusChange(object sender, EventArgs e)
        {
            if(HeightTextBox.Focused)
            {
                this.TextBoxFocus = true;
            }
            else if(WeightTextBox.Focused)
            {
                this.TextBoxFocus = false;
            }
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveError == false)
            {
                double firstNumber = 0;
                double secondNumber = 0;
                double result = 0;
                bool divisionByZero = false;

                this.My_Height = HeightTextBox.Text;
                this.My_Weight = WeightTextBox.Text;

                firstNumber = Convert.ToDouble(this.My_Height);


                secondNumber = Convert.ToDouble(this.My_Weight);

                if (firstNumber == 0)
                {
                    divisionByZero = true;
                }
                else
                {
                    if (Metric.Checked == true)
                    {
                        result = secondNumber / (firstNumber * firstNumber);
                    }
                    else if (Imperial.Checked == true)
                    {
                        result = (secondNumber * 703) / (firstNumber * firstNumber);
                    }
                }

                if (divisionByZero)
                {
                    BMITextBox.Text = "DIV by Zero";
                    this.ActiveError = true;
                }
                else
                {
                    if(result < 18.5)
                    {
                        ResultTextBox.Text = "Underweight";
                    }
                    else if(result >= 18.5 && result < 24.9)
                    {
                        ResultTextBox.Text = "Normal";
                    }
                    else if(result >= 24.9 && result < 30)
                    {
                        ResultTextBox.Text = "Overweight";
                    }
                    else if(result >= 30)
                    {
                        ResultTextBox.Text = "Obese";
                    }
                    BMITextBox.Text = result.ToString();
                }

                
            }
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (TextBoxFocus == true)
            {
                if (HeightTextBox.Text.Length == 1)
                {
                    HeightTextBox.Text = "0";
                }
                else if (HeightTextBox.Text.Length > 1)
                {
                    HeightTextBox.Text = HeightTextBox.Text.Remove(HeightTextBox.Text.Length - 1);
                }
                

            }
            else if (TextBoxFocus == false)
            {

                if (WeightTextBox.Text.Length == 1)
                {
                    WeightTextBox.Text = "0";
                }
                else if (WeightTextBox.Text.Length > 1)
                {
                    WeightTextBox.Text = WeightTextBox.Text.Remove(WeightTextBox.Text.Length - 1);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            
            this.ActiveError = false;
        }
    }
}
