using FormsDeskHolerite.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDeskHolerite.TelasHomeForms.telasCadastrar.FormsTiposCadastros;
using System.Drawing.Text;

namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarEmpresa : Form
    {
        private int i;

        public FormCadastrarEmpresa()
        {
            InitializeComponent();
        }

   
        private void clsCircularBoxIcon1_Click(object sender, EventArgs e)
        {
            i++;
            Label contatoLabel = new Label();
            contatoLabel.Text = "Tipo de contato";
            tipoContatoFlowLayoutPanel.Controls.Add(contatoLabel);
            ComboBox comboBoxTipoContato = new ComboBox();
            comboBoxTipoContato.Name = "tipoContatoComboBox" + i.ToString();
            tipoContatoFlowLayoutPanel.Controls.Add( comboBoxTipoContato);

            Label contatoLabelDois = new Label();
            contatoLabelDois.Text = "Contato";        
            contatoFlowLayoutPanel.Controls.Add(contatoLabelDois);
            TextBox contatoTextBox = new TextBox();
            contatoTextBox.Name = "contatoTxtBox" + i.ToString();
            contatoFlowLayoutPanel.Controls.Add(contatoTextBox);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
