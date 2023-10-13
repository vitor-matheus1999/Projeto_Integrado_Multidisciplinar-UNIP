using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class Form5 : Form
    {
        private Dictionary<DateTime, Tuple<int, int>> horasPorData = new Dictionary<DateTime, Tuple<int, int>>();

        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InicializarDados();
        }

        private void InicializarDados()
        {

            Random random = new Random();
            DateTime dataAtual = DateTime.Now.Date;

            for (int i = 0; i < 90; i++)      
            {
                int horasTrabalhadas = random.Next(7, 10);
                int horasDeTrabalho = 8;
                int horasExtras = Math.Max(0, horasTrabalhadas - horasDeTrabalho);

                horasPorData[dataAtual] = new Tuple<int, int>(horasTrabalhadas, horasExtras);
                dataAtual = dataAtual.AddDays(-1);
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            DateTime dataSelecionada = dateTimePickerData.Value.Date;


            if (horasPorData.ContainsKey(dataSelecionada))
            {

                Tuple<int, int> horas = horasPorData[dataSelecionada];
                int horasTrabalhadas = horas.Item1;
                int horasExtras = horas.Item2;


                textBox1.Text = $"{horasTrabalhadas:D2}:00";
                textBox2.Text = $"{horasExtras:D2}:00";
            }
            else
            {

                textBox1.Text = "N/A";
                textBox2.Text = "N/A";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}