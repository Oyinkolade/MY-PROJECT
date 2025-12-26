namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = "";
        string operation = "";
        double result = 0;

        private void one_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "1";
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "2";
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "3";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "4";
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "5";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "6";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "7";
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "8";
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "9";
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "0";
        }

        private void addition_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "+";
        }

        private void subtraction_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "-";
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "*";
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += "/";
        }

        private void equal_to_button_Click(object sender, EventArgs e)
        {
            string expression = display_textbox.Text;
            double total = 0;
            string numberText = "";
            char currentOp = '+';
            int index = 0;

            while (index < expression.Length)
            {
                char letter = expression[index];

                if (char.IsDigit(letter))
                {
                    numberText = numberText + letter;
                }

                if (letter == '.')
                {
                    numberText = numberText + letter;
                }

                if (letter == '+')
                {
                    double currentNumber = Convert.ToDouble(numberText);

                    if (currentOp == '+') { total = total + currentNumber; }
                    else if (currentOp == '-') { total = total - currentNumber; }
                    else if (currentOp == '*') { total = total * currentNumber; }
                    else if (currentOp == '/') { total = total / currentNumber; }

                    currentOp = '+';
                    numberText = "";
                }

                if (letter == '-')
                {
                    double currentNumber = Convert.ToDouble(numberText);

                    if (currentOp == '+') { total = total + currentNumber; }
                    else if (currentOp == '-') { total = total - currentNumber; }
                    else if (currentOp == '*') { total = total * currentNumber; }
                    else if (currentOp == '/') { total = total / currentNumber; }

                    currentOp = '-';
                    numberText = "";
                }

                if (letter == '*')
                {
                    double currentNumber = Convert.ToDouble(numberText);

                    if (currentOp == '+') { total = total + currentNumber; }
                    else if (currentOp == '-') { total = total - currentNumber; }
                    else if (currentOp == '*') { total = total * currentNumber; }
                    else if (currentOp == '/') { total = total / currentNumber; }

                    currentOp = '*';
                    numberText = "";
                }

                if (letter == '/')
                {
                    double currentNumber = Convert.ToDouble(numberText);

                    if (currentOp == '+') { total = total + currentNumber; }
                    else if (currentOp == '-') { total = total - currentNumber; }
                    else if (currentOp == '*') { total = total * currentNumber; }
                    else if (currentOp == '/') { total = total / currentNumber; }

                    currentOp = '/';
                    numberText = "";
                }

                if (index == expression.Length - 1)
                {
                    double currentNumber = Convert.ToDouble(numberText);

                    if (currentOp == '+') { total = total + currentNumber; }
                    else if (currentOp == '-') { total = total - currentNumber; }
                    else if (currentOp == '*') { total = total * currentNumber; }
                    else if (currentOp == '/') { total = total / currentNumber; }
                }

                index = index + 1;
            }

            display_textbox.Text = total.ToString();
        }




        private void clear_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text = "";
        }

        private void decimal_point_button_Click(object sender, EventArgs e)
        {
            display_textbox.Text += ".";
        }

        private void sin_button_Click(object sender, EventArgs e)
        {
            if (display_textbox.Text != "")
            {
                double angle = Convert.ToDouble(display_textbox.Text);
                display_textbox.Text = Math.Sin(angle * Math.PI / 180).ToString();
            }
        }

        private void cos_button_Click(object sender, EventArgs e)
        {
            if (display_textbox.Text != "")
            {
                double angle = Convert.ToDouble(display_textbox.Text);
                display_textbox.Text = Math.Cos(angle * Math.PI / 180).ToString();
            }
        }

        private void tan_button_Click(object sender, EventArgs e)
        {
            if (display_textbox.Text != "")
            {
                double angle = Convert.ToDouble(display_textbox.Text);
                display_textbox.Text = Math.Tan(angle * Math.PI / 180).ToString();
            }
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            if (display_textbox.Text != "")
            {
                double num = Convert.ToDouble(display_textbox.Text);
                display_textbox.Text = Math.Log10(num).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
       {

       }
    }
}
