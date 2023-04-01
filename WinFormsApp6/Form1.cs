namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] mas = textBox1.Text.ToCharArray();
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas.Length >= 8)
                    one = 1;
                if (Char.IsLower(mas[i]))
                    two = 1;
                if (Char.IsUpper(mas[i]))
                    three = 1;
                if(Char.IsDigit(mas[i]))
                    four = 1;
                if (one == 1 && two == 1 && three == 1 && four == 1)
                    label1.Text = "подходит";
                else
                    label1.Text = "не подходит";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Random rnd = new Random();
            string x = "asdfghjklqwertyuiio";
            string y = "ASDFGHJKLQWERTYUIOP";
            string z = "1234567890";
            label2.Text += x[rnd.Next(0, 18)];
            label2.Text += y[rnd.Next(0, 18)];
            label2.Text += z[rnd.Next(0, 9)];
            for (int i = 0; i < 5; i++)
            {
                label2.Text += x[rnd.Next(0, 18)];
            }
        }
    }
}