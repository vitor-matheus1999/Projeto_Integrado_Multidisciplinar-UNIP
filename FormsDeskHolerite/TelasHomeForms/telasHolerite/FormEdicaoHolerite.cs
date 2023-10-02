using FormsDeskHolerite.CommandForms;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using FormsDeskHolerite.TelasHomeForms.telasHolerite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasHolerite
{
    public partial class FormEdicaoHolerite : Form
    {
        Funcionario funcionario = new Funcionario();
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        ClsWorkForm ShowChildForm = new ClsWorkForm();
        private int idEmpresa;
        private int idSetor;

        public FormEdicaoHolerite()
        {
            InitializeComponent();
        }

        public FormEdicaoHolerite( int idEmpresaEscolhida, int idSetorEscolhido, string nomeEmpresaEscolhido, string nomeSetorEscolhido)
        {
            InitializeComponent();
            idEmpresa = idEmpresaEscolhida;
            idSetor = idSetorEscolhido;
            empresaLabel.Text = nomeEmpresaEscolhido;
            setorLabel.Text = nomeSetorEscolhido;
            foreach (Funcionario funcionario in bdFuncionario.GetInformacaoFuncionario(idEmpresaEscolhida, idSetorEscolhido))
            {
                Panel newPanel = new Panel();
                newPanel.Name = "holerite" + funcionario.GetNomeFuncionario;
                newPanel.BackColor = System.Drawing.Color.DimGray;
                newPanel.Size = new System.Drawing.Size(454, 45);
                holeriteFlowLayoutPanel.Controls.Add(newPanel);

                Label newLabel = new Label();
                newLabel.Name = "label" + funcionario.GetNomeFuncionario;
                newLabel.AutoSize = false;
                newLabel.Size = new System.Drawing.Size(247, 19);
                newLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                newLabel.Text = funcionario.GetNomeFuncionario;
                newLabel.Location = new System.Drawing.Point(50, 16);
                newPanel.Controls.Add(newLabel);

                Button newButton = new Button();
                newButton.Name = "editarHoleriteButton";
                newButton.Size = new System.Drawing.Size(44, 35);
                newButton.Location = new System.Drawing.Point(349, 5);
                newButton.Image = global::FormsDeskHolerite.Properties.Resources.opcoes_10;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.BackColor = System.Drawing.Color.DimGray;
                newButton.Click += new System.EventHandler(editarHoleriteButton_Click);

                 void editarHoleriteButton_Click(object sender, EventArgs e)
                {
                    TabPage tabPage = new TabPage("Holerite " + funcionario.GetNomeFuncionario + "          ");
                    tabPage.AutoScroll = true;
                    FormHolerite.holeriteTabControl.TabPages.Add(tabPage);
                    ShowChildForm.openChildForm(new FormFuncionarioHolerite(funcionario.GetIdFuncionario),tabPage );
                }
                newPanel.Controls.Add(newButton);
            }
        }

        private void checarHoleriteFuncionarioButton_Click(object sender, EventArgs e)
        {            
        }

        private void fecharFormEdicaoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
