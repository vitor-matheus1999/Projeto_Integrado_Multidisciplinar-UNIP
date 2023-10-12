using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Relatorio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            buttonCalcularDesconto.Click += ButtonCalcularDesconto_Click;
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