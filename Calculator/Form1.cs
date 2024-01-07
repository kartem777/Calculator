using System.Configuration;
using System.Runtime.ExceptionServices;
namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click;
            button13.Click += button13_Click;
            button16.Click += button16_Click;
            button17.Click += button17_Click;
            button11.Click += button11_Click;
            button12.Click += button12_Click;
            button14.Click += button14_Click;
            button15.Click += button15_Click;
            button18.Click += button18_Click;
            button19.Click += button19_Click;
            button18.Enabled = false;
            textBox4.TextChanged += textBox1_TextChanged;
            textBox5.TextChanged += textBox2_TextChanged;
            textBox6.TextChanged += textBox3_TextChanged;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox8.TextChanged += textBox8_TextChanged;
        }
        int factorial(int x)
        {
            if (x == 1) { return x; }
            else return x * factorial(x - 1);
        }
        double first = 0;
        double second = 0;
        int sign = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button1.Text; }
            else { label1.Text = button1.Text; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button2.Text; }
            else { label1.Text = button2.Text; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button3.Text; }
            else { label1.Text = button3.Text; }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button4.Text; }
            else { label1.Text = button4.Text; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button5.Text; }
            else { label1.Text = button5.Text; }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button6.Text; }
            else { label1.Text = button6.Text; }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button7.Text; }
            else { label1.Text = button7.Text; }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button8.Text; }
            else { label1.Text = button8.Text; }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button9.Text; }
            else { label1.Text = button9.Text; }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text += button10.Text; }
            else { label1.Text = button10.Text; }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (char c in label1.Text)
            {
                if (c == '.')
                {
                    flag = true; break;
                }
            }
            if (flag == false)
            {
                label1.Text += button13.Text;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 1)
            {
                string a = "";
                int count = 0;
                for (int i = 0; i < label1.Text.Length - 1; i++)
                {
                    a += label1.Text[i];
                }
                label1.Text = a;
            }
            else
            {
                label1.Text = "0";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(label1.Text);
            sign = 1;
            button18.Enabled = true;
            button17_Click(sender, e);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(label1.Text);
            sign = 2;
            button18.Enabled = true;
            button17_Click(sender, e);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(label1.Text);
            sign = 3;
            button18.Enabled = true;
            button17_Click(sender, e);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(label1.Text);
            sign = 4;
            button18.Enabled = true;
            button17_Click(sender, e);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(label1.Text);
            double third = 0;
            if (sign == 1)
                third = first + second;
            else if (sign == 2)
                third = first - second;
            else if (sign == 3)
                third = first * second;
            else if (sign == 4)
                third = first / second;
            button18.Enabled = false;
            label1.Text = third.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(label1.Text) * (-1);
            label1.Text = a.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
                label5.Text = "US dollar: " + (Convert.ToDouble(textBox4.Text) / 38) + "\n Euro: " + (Convert.ToDouble(textBox4.Text) / 41.5);
            else label5.Text = "0";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
                label6.Text = "grn: " + (Convert.ToDouble(textBox5.Text) * 38) + "\n Euro: " + (Convert.ToDouble(textBox5.Text) * 0.91);
            else label6.Text = "0";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
                label7.Text = "US dollar: " + (Convert.ToDouble(textBox6.Text) / 0.91) + "\n grn: " + (Convert.ToDouble(textBox6.Text) * 41.5);
            else label7.Text = "0";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 0)
            {
                double a = Math.Sqrt(Convert.ToDouble(textBox7.Text));
                label2.Text = a.ToString();
            }
            else label2.Text = "0";
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 0)
            {
                int a = factorial(Convert.ToInt32(textBox8.Text));
                label11.Text = a.ToString();
            }
            else label11.Text = "1";
        }
    }
}