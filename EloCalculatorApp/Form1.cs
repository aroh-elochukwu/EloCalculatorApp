namespace EloCalculatorApp
{
    public partial class Form1 : Form
    {
        private double DisplayScreenAmount = 0;
        private string OperationCalled = "";
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private  void onKeyDown(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad0)
            {
                button_NumberZero.PerformClick();            

            }else if (e.KeyChar == (char)Keys.NumPad1)
            {
                button_NumberOne.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad2)
            {
                button_NumberTwo.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad3)
            {
                button_NumberThree.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad4)
            {
                button_NumberFour.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad5)
            {
                button_NumberFive.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad6)
            {
                button_NumberSix.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad7)
            {
                button_NumberSeven.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad8)
            {
                button_NumberEight.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad9)
            {
                button_NumberNine.PerformClick();
            }
            
        }

        private void button_NumberZero_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "0";
            isOperationPerformed = false;

        }

        private void button_DecimalPoint_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            if (!textBox_ResultDisplay.Text.Contains("."))
            {
                textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + ".";
                isOperationPerformed = false;

            }
            

        }

        private void button_NumberOne_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "1";
            isOperationPerformed = false;
        }

        private void button_NumberTwo_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "2";
            isOperationPerformed = false;
        }

        private void button_NumberThree_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "3";
            isOperationPerformed = false;
        }

        private void button_NumberFour_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "4";
            isOperationPerformed = false;
        }

        private void button_NumberFive_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "5";
            isOperationPerformed = false;
        }

        private void button_NumberSix_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "6";
            isOperationPerformed = false;
        }

        private void button_NumberSeven_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "7";
            isOperationPerformed = false;
        }

        private void button_NumberEight_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "8";
            isOperationPerformed = false;
        }

        private void button_NumberNine_Click(object sender, EventArgs e)
        {
            if (textBox_ResultDisplay.Text == "0" || isOperationPerformed)
            {
                textBox_ResultDisplay.Clear();
            }
            textBox_ResultDisplay.Text = textBox_ResultDisplay.Text + "9";
            isOperationPerformed = false;
        }

        private void button_Addition_Click(object sender, EventArgs e)
        {
            if (DisplayScreenAmount != 0)
            {
                OperationCalled = "+";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;
                button_EqualTo.PerformClick();
                
            }else
            {
                OperationCalled = "+";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;
            }
            

        }

        private void button_Subtraction_Click(object sender, EventArgs e)
        {
            if (DisplayScreenAmount != 0)
            {                
                OperationCalled = "-";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;
                button_EqualTo.PerformClick();
            }
            else
            {
                OperationCalled = "-";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;

            }
            

        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            if (DisplayScreenAmount != 0)
            {               
                OperationCalled = "*";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;
                button_EqualTo.PerformClick();
            }
            else
            {
                OperationCalled = "*";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;

            }
            
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            if (DisplayScreenAmount != 0)
            {                
                OperationCalled = "/";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;
                button_EqualTo.PerformClick();
            }
            else
            {
                OperationCalled = "/";
                DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
                label_PresentOperation.Text = DisplayScreenAmount + " " + OperationCalled;
                isOperationPerformed = true;

            }
            
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_ResultDisplay.Text = "0";
            
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ResultDisplay.Text = "0";
            DisplayScreenAmount = 0;
            label_PresentOperation.Text = "";
        }

        private void button_EqualTo_Click(object sender, EventArgs e)
        {
            switch(OperationCalled)
            {
                case "+":
                    textBox_ResultDisplay.Text = (DisplayScreenAmount + Double.Parse(textBox_ResultDisplay.Text)).ToString();
                    break;
                case "/":
                    textBox_ResultDisplay.Text = (DisplayScreenAmount / Double.Parse(textBox_ResultDisplay.Text)).ToString();
                    break;
                case "-":
                    textBox_ResultDisplay.Text = (DisplayScreenAmount - Double.Parse(textBox_ResultDisplay.Text)).ToString();
                    break;
                case "*":
                    textBox_ResultDisplay.Text = (DisplayScreenAmount * Double.Parse(textBox_ResultDisplay.Text)).ToString();
                    break;
            }

            DisplayScreenAmount = Double.Parse(textBox_ResultDisplay.Text);
            
            
        }

        
    }
}