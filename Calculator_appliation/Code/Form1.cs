namespace Calculatoe_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + nine.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + zero.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + mul.Text;
            option = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + sub.Text;
            option = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + add.Text;
            option = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            // textBox1.Text = textBox1.Text + div.Text;
            option = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textBox1.Clear();

            textBox1.Text = result.ToString();
        }
    }
}