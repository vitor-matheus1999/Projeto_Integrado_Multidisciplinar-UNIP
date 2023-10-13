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
