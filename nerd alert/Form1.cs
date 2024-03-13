namespace nerd_alert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            soma = a + b;
            textBox3.Text = soma.ToString();
            textBox4.Text = "+";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            soma = a - b;
            textBox3.Text = soma.ToString();
            textBox4.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            soma = a * b;
            textBox3.Text = soma.ToString();
            textBox4.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            soma = a / b;
            textBox3.Text = soma.ToString();

            textBox4.Text = "÷";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}