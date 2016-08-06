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

        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void BMI_CalculatorButton_Click(object sender, EventArgs e)
        {
            


            // create a reference to the sender object 
            // and tell c-sharp that it is a button
            Button buttonClicked = (Button)sender;

            if (TextBoxFocus == true)
            {
                
                string HeightResult = HeightTextBox.Text;// read the string in the TextBox
                HeightResult += buttonClicked.Text;// add the text of the button clicked to the currentResult
                HeightTextBox.Text = HeightResult;// update the ResultTextBox
                this.ActiveControl = HeightTextBox;
            }
            else if(TextBoxFocus == false)
            {
                
                string WeightResult = WeightTextBox.Text;// read the string in the TextBox
                WeightResult += buttonClicked.Text;// add the text of the button clicked to the currentResult
                WeightTextBox.Text = WeightResult;// update the ResultTextBox
                this.ActiveControl = WeightTextBox;
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
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

        }




    }
}
