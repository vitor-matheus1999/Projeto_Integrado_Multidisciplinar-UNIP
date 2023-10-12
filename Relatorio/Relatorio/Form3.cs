using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Relatorio
{
    public partial class Form3 : Form
    {
        private int horasTrabalhadasAleatorias;
        private int horasExtras;

        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public TimeSpan HorasTrabalhadas { get; set; }
        public TimeSpan HorasExtras { get; set; }

        private void CalcularHorasExtras()
        {
            Random random = new Random();
            horasTrabalhadasAleatorias = random.Next(1, 13);
            int horasDeTrabalho = 8;
            horasExtras = horasTrabalhadasAleatorias - horasDeTrabalho;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = random.Next(40, 44) + " horas";
            textBox2.Text = random.Next(1, 3) + " horas";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}