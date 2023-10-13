using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasArquivar
{
    public partial class FormEdicaoArquivamento : Form
    {
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        List<Funcionario> listaFuncionarioArquivados = new List<Funcionario>();
        List<Funcionario> listaFuncionarioDesarquivados = new List<Funcionario>();
        public System.Drawing.Color cardFuncionarioBackColor = System.Drawing.Color.DimGray;

        public FormEdicaoArquivamento()
        {
            InitializeComponent();
        }

        public FormEdicaoArquivamento(int idEmpresaEscolhida, int idSetorEscolhido, string nomeEmpresaEscolhido, string nomeSetorEscolhido)
        {
            InitializeComponent();           
            empresaLabel.Text = nomeEmpresaEscolhido;
            setorLabel.Text = nomeSetorEscolhido;
            foreach (Funcionario funcionario in bdFuncionario.GetInformacaoFuncionario(idEmpresaEscolhida, idSetorEscolhido))
            {           
                if(funcionario.GetFuncionarioArquivado == true)
                {
                    cardFuncionarioBackColor = Color.FromArgb(157, 212, 194);
                }
                Panel newPanel = new Panel();
                newPanel.Name = "holerite" + funcionario.GetNomeFuncionario;
                newPanel.BackColor = cardFuncionarioBackColor;
                newPanel.Size = new System.Drawing.Size(454, 45);
                arquivamentoFlowLayoutPanel.Controls.Add(newPanel);

                Label newLabel = new Label();
                newLabel.Name = "label" + funcionario.GetNomeFuncionario;
                newLabel.AutoSize = false;
                newLabel.Size = new System.Drawing.Size(247, 19);
                newLabel.ForeColor = System.Drawing.Color.Black; 
                newLabel.Text = funcionario.GetNomeFuncionario;
                newLabel.Location = new System.Drawing.Point(50, 16);
                newPanel.Controls.Add(newLabel);

                CheckBox newCheckBox= new CheckBox();
                newCheckBox.Location = new System.Drawing.Point(395, 16);
                newCheckBox.Name = funcionario.GetNomeFuncionario + " RadioButton";
                newCheckBox.Size = new System.Drawing.Size(85, 17);
                newCheckBox.TabIndex = 0;
                newCheckBox.TabStop = true;
                newCheckBox.Text = "";
                newCheckBox.CheckedChanged += new System.EventHandler(checkBox_CheckedChanged);

                if (funcionario.GetFuncionarioArquivado == true)
                {
                    newCheckBox.Checked = true;
                }


                void checkBox_CheckedChanged(object sender, EventArgs e)
                {
                    if (newCheckBox.Name.Contains(funcionario.GetNomeFuncionario + " RadioButton") && newCheckBox.Checked)
                    {
                        newPanel.BackColor = Color.FromArgb(157, 212, 194);
                        listaFuncionarioDesarquivados.Remove(funcionario);
                        listaFuncionarioArquivados.Add(funcionario);
                    }
                    else
                    {
                        newPanel.BackColor = System.Drawing.Color.DimGray;
                        listaFuncionarioArquivados.Remove(funcionario);
                        listaFuncionarioDesarquivados.Add(funcionario);
                    }
                }

                newPanel.Controls.Add(newCheckBox);
            }
            if(bdFuncionario.GetInformacaoFuncionario(idEmpresaEscolhida, idSetorEscolhido).Count == 0)
            {
                avisoSemFuncionarioSetorLabel.Visible = true;
                enviarHoleritesButton.Visible = false;
            }
        }

        private void enviarHoleritesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Arquivar ou Desarquivar os funcionários selecionados ?","AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                foreach(Funcionario funcionario in listaFuncionarioArquivados)
                {
                    bdFuncionario.SetFuncionarioArquivado(funcionario.GetIdFuncionario, true);
                }

                foreach(Funcionario funcionario in listaFuncionarioDesarquivados)
                {
                    bdFuncionario.SetFuncionarioArquivado(funcionario.GetIdFuncionario, false);
                } 
            }
        }
    }
}
