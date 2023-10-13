using Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDeskHolerite.TelasHomeForms.telasRelatório.Relatorios;

namespace FormsDeskHolerite.TelasHomeForms.telasRelatório
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCPF(textBox1.Text))
            {
                FormRelatorioHoras relatorioHoras = new FormRelatorioHoras();
                relatorioHoras.Show();
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
                FormRelatorioHorasExtras formRelatorio = new FormRelatorioHorasExtras();
                formRelatorio.Show();
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
                FormRelatorioFaltas relatorioFaltas = new FormRelatorioFaltas();
                relatorioFaltas.Show();
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPJ válido primeiro.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Digite aqui seu CPF...";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedItem.ToString() == "CPF")
            {
                textBox1.Text = "Digite seu CPF...";
            }
            else if (domainUpDown1.SelectedItem.ToString() == "CNPJ")
            {
                textBox1.Text = "Digite seu CNPJ...";
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

