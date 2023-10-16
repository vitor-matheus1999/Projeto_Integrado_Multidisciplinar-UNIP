using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasRelatório.Relatorios
{
    public partial class FormRelatorioFaltas : Form
    {
        public FormRelatorioFaltas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            ButtonCalcularDesconto.Click += ButtonCalcularDesconto_Click;
        }

        private void ButtonCalcularDesconto_Click(object sender, EventArgs e)
        {

            string textoSalario = textBox1.Text.Replace("R$", "").Trim();


            if (decimal.TryParse(textoSalario, out decimal salario))
            {

                if (int.TryParse(textBox2.Text, out int faltas))
                {

                    decimal valorPorDia = salario / 30;
                    decimal desconto = valorPorDia * faltas;

                    labelResultado.Visible = true;
                    labelResultado.Text = "Desconto: -R$" + desconto.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido de faltas.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um salário válido.");
            }
        }
    }
}

