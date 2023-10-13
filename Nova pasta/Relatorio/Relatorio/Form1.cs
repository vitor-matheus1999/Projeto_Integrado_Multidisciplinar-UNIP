namespace Relatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCPF(textBox1.Text))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPJ válido primeiro.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerificarCPF(textBox1.Text))
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPJ válido primeiro.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VerificarCPF(textBox1.Text))
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPJ válido primeiro.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Digite aqui seu CPF...";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedItem.ToString() == "CPF")
            {
                textBox1.PlaceholderText = "Digite seu CPF...";
            }
            else if (domainUpDown1.SelectedItem.ToString() == "CNPJ")
            {
                textBox1.PlaceholderText = "Digite seu CNPJ...";
            }
        }

        private bool VerificarCPF(string cpf)
        {

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");


            if (cpf.Length == 11 || cpf.Length == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonVerificarCPF_Click(object sender, EventArgs e)
        {
            if (VerificarCPF(textBox1.Text))
            {
                MessageBox.Show("CPF válido! Acesso permitido aos formulários.");
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPJ válido. Acesso negado aos formulários.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}