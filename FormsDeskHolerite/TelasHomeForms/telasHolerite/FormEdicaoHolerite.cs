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
using System.Net.Http.Headers;
using System.Windows.Controls.Primitives;

namespace FormsDeskHolerite.TelasHomeForms.telasHolerite
{
    public partial class FormEdicaoHolerite : Form
    {
        Funcionario funcionario = new Funcionario();
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        ClsWorkForm ShowChildForm = new ClsWorkForm();
        Panel newPanel = new Panel();
        public System.Drawing.Color holeriteBackColor = System.Drawing.Color.DimGray;
        public System.Drawing.Color labelColor = System.Drawing.SystemColors.ControlLightLight;
        public System.Drawing.Color backColorButton = System.Drawing.Color.DimGray;
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
                if(funcionario.GetHoleriteFinalizado == true)
                {
                    holeriteBackColor = Color.FromArgb(157, 212, 194);
                    backColorButton = Color.FromArgb(157, 212, 194);
                    labelColor = System.Drawing.Color.Black;
                }

                newPanel.Name = "holerite" + funcionario.GetNomeFuncionario;
                newPanel.BackColor = holeriteBackColor;
                newPanel.Size = new System.Drawing.Size(454, 45);
                holeriteFlowLayoutPanel.Controls.Add(newPanel);

                Label newLabel = new Label();
                newLabel.Name = "label" + funcionario.GetNomeFuncionario;
                newLabel.AutoSize = false;
                newLabel.Size = new System.Drawing.Size(247, 19);
                newLabel.ForeColor = labelColor;
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
                newButton.BackColor = backColorButton;
                newButton.Click += new System.EventHandler(editarHoleriteButton_Click);

                 void editarHoleriteButton_Click(object sender, EventArgs e)
                {
                    TabPage tabPage = new TabPage("Holerite " + funcionario.GetNomeFuncionario + "               ");
                    tabPage.AutoScroll = true;
                    FormHolerite.holeriteTabControl.TabPages.Add(tabPage);
                    ShowChildForm.openChildForm(new FormFuncionarioHolerite(funcionario.GetIdFuncionario),tabPage );
                }


                newPanel.Controls.Add(newButton);
            }

            if(bdFuncionario.GetInformacaoFuncionario(idEmpresaEscolhida, idSetorEscolhido).Count == 0)
            {
                avisoSemFuncionarioSetorLabel.Visible = true;
                enviarHoleritesButton.Visible = false;
            }       
        }

        private void enviarHoleritesButton_Click(object sender, EventArgs e)
        {
            var quantidadeFuncionariosHoleriteFinalizado = 0;
            var quantidadeFuncionariosHoleriteAberto = 0;
            foreach (Funcionario funcionario in bdFuncionario.GetInformacaoFuncionario(idEmpresa, idSetor))
            {
                if (funcionario.GetHoleriteFinalizado == false)
                {
                    quantidadeFuncionariosHoleriteAberto++;
                    if (MessageBox.Show("O funcionario " + funcionario.GetNomeFuncionario + " Ainda não teve sua Folha de Pagamento finalizada, gostaria de finaliza-la ? " , "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TabPage tabPage = new TabPage("Holerite " + funcionario.GetNomeFuncionario + "               ");
                        tabPage.AutoScroll = true;
                        FormHolerite.holeriteTabControl.TabPages.Add(tabPage);
                        ShowChildForm.openChildForm(new FormFuncionarioHolerite(funcionario.GetIdFuncionario), tabPage);
                        return;
                    }   
                    
                }
                if (funcionario.GetHoleriteFinalizado == true)
                {
                    quantidadeFuncionariosHoleriteFinalizado++;
                }
            }

            if (quantidadeFuncionariosHoleriteAberto == 0)
            {
                MessageBox.Show("Não existem folhas de pagamento em aberto, todas as folhas já podem ser vizualizadas pelos funcionários.", "AVISO");
            }
        }
    }
}
