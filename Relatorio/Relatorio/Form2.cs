using System;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = random.Next(40, 44) + " horas";
            textBox2.Text = random.Next(1, 3) + " horas";
            textBox3.Text = random.Next(1, 4).ToString();
        }
    }
}
