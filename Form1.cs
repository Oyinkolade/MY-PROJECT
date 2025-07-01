namespace My_First_App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Sum_button_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Num1_textbox.Text);
            int b = Convert.ToInt32(Num2_textbox.Text);
            int sum = a + b;
            MessageBox.Show(Convert.ToString(sum));
        }

        private void Difference_button_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(Num1_textbox.Text);
            int d = Convert.ToInt32(Num2_textbox.Text);
            int difference = c - d;
            MessageBox.Show(Convert.ToString(difference));
        }

        private void Product_button_Click(object sender, EventArgs e)
        {
            int f = Convert.ToInt32(Num1_textbox.Text);
            int g = Convert.ToInt32(Num2_textbox.Text);
            int product = f * g;
            MessageBox.Show(Convert.ToString(product));
        }

        private void Share_button_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(Num1_textbox.Text);
            int i = Convert.ToInt32(Num2_textbox.Text);
            int share = h / i;
            MessageBox.Show(Convert.ToString(share));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
