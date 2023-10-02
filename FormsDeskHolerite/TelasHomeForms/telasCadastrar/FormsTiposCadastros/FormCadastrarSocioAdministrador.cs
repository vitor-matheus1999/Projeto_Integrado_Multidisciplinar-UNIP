using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;

namespace FormsDeskHolerite.TelasHomeForms.telasCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarSocioAdministrador : Form
    {
        ClsBancoDadosSocio sqlSocio = new ClsBancoDadosSocio();
        ClsBancoDadosEmpresa sqlEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor sqlSetor = new ClsBancoDadosSetor();
        ClsBancoDadosFuncionario sqlAdm = new ClsBancoDadosFuncionario();

        public FormCadastrarSocioAdministrador()
        {
            InitializeComponent();
            funcionarioAdmcomboBox.SelectedIndex = 0;
            tipoSocioComboBox.SelectedIndex = 0;
            tipoRegistroComboBox.SelectedIndex = 0;
            sqlEmpresa.GetEmpresasComboBox(empresaSocioComboBox);
            sqlEmpresa.GetEmpresasComboBox(empresaAdmComboBox);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }      
        private void socioPanelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (socioPanelCheckBox.Checked)
            {
                socioPanelCheckBox.Text = "";
                empresaSocioComboBox.Enabled = true;
                socioAdmSplitContainer.Panel1.BackColor = Color.FromArgb(204, 185, 215);
            }
            else
            {
                socioPanelCheckBox.Text = "Liberar Cadastro Sócio";
                empresaSocioComboBox.Enabled = false;
                empresaSocioComboBox.SelectedIndex = 0;
                tipoSocioComboBox.Enabled = false;
                tipoSocioComboBox.SelectedIndex = 0;
                nomeCompletoSocioTextBox.Enabled = false;
                nomeCompletoSocioTextBox.Clear();
                tipoRegistroComboBox.Enabled = false;
                tipoRegistroComboBox.SelectedIndex = 0;
                descricaoRegistroSocioTextBox.Enabled = false;
                descricaoRegistroSocioTextBox.Clear();
                socioAdmSplitContainer.Panel1.BackColor = Color.FromArgb(164, 142, 173);
            }
        }   
        private void empresaSocioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaSocioComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                tipoSocioComboBox.Enabled = true;
            }
        }
        private void tipoSocioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tipoSocioComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                nomeCompletoSocioTextBox.Enabled = true;
                tipoRegistroComboBox.Enabled = true;
                descricaoRegistroSocioTextBox.Enabled = true;
            }
        }
        private void admPanelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (admPanelCheckBox.Checked)
            {
                admPanelCheckBox.Text = "";
                empresaAdmComboBox.Enabled = true;           
                socioAdmSplitContainer.Panel2.BackColor = Color.FromArgb(204, 185, 215);
            }
            else
            {
                admPanelCheckBox.Text = "Liberar Cadastro Administrador";
                empresaAdmComboBox.Enabled = false;
                empresaAdmComboBox.SelectedIndex = 0;
                funcionarioAdmcomboBox.Enabled = false;
                empresaAdmComboBox.SelectedIndex = 0;
                funcionarioAdmcomboBox.SelectedIndex = 0;
                nomeCompletoFuncionarioAdmTextBox.Clear();
                setorFuncionarioAdmtextBox.Clear();
                nivelHierarquicoFuncionarioAdmTextBox.Clear();
                socioAdmSplitContainer.Panel2.BackColor = Color.FromArgb(164, 142, 173);
            }
        }
        private void empresaAdmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaAdmComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                nomeCompletoFuncionarioAdmTextBox.Clear();
                setorFuncionarioAdmtextBox.Clear();
                nivelHierarquicoFuncionarioAdmTextBox.Clear();
                funcionarioAdmcomboBox.Enabled = false;
                funcionarioAdmcomboBox.Enabled = true;             
            }
        }
        private void funcionarioAdmcomboBox_EnabledChanged(object sender, EventArgs e)
        {
            if(funcionarioAdmcomboBox.Enabled == true)
            {
                sqlAdm.GetFuncionariosAdmEmpresaComboBox(funcionarioAdmcomboBox, Int32.Parse(empresaAdmComboBox.SelectedValue.ToString()));
            }
            else
            {
                return;
            }
        }
        private void funcionarioAdmcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (funcionarioAdmcomboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                nomeCompletoFuncionarioAdmTextBox.Text = funcionarioAdmcomboBox.Text;
                var idSetor =((DataRowView)funcionarioAdmcomboBox.SelectedItem).Row.Field<int>("id_Setor");
                sqlSetor.GetFuncionariosSetorHierarquiaTextBox(setorFuncionarioAdmtextBox, nivelHierarquicoFuncionarioAdmTextBox, idSetor);
            }
        }
        private void salvarInfoSalarioButton_Click(object sender, EventArgs e)
        {
            bool socio = false;
            bool adm = false;
            if (socioPanelCheckBox.Checked)
            {
                if (empresaSocioComboBox.SelectedIndex == 0 || tipoSocioComboBox.SelectedIndex == 0 || tipoRegistroComboBox.SelectedIndex == 0 || descricaoRegistroSocioTextBox.Text.Equals(null))
                {
                    MessageBox.Show("Campos de cadastro nulos.");
                    return;
                }
                else
                {
                    socio = sqlSocio.SetDadosSocio(Int32.Parse(empresaSocioComboBox.SelectedValue.ToString()), tipoSocioComboBox.Text, nomeCompletoSocioTextBox.Text, tipoRegistroComboBox.Text, descricaoRegistroSocioTextBox.Text);
                }
            }
            if (admPanelCheckBox.Checked)
            {

                if(empresaAdmComboBox.SelectedIndex == 0 || funcionarioAdmcomboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Campos de cadastro nulos.");
                    return;
                }
                else
                {
                    adm = sqlAdm.SetDadosFuncionario(Int32.Parse(empresaAdmComboBox.SelectedValue.ToString()), ((DataRowView)funcionarioAdmcomboBox.SelectedItem).Row.Field<int>("id_Funcionario"));

                }
            }
            if(socio == true && adm == true || socio == true && adm == false || socio == false && adm == true)
            {
                if(socioPanelCheckBox.Checked == true)
                {
                    empresaSocioComboBox.SelectedIndex = 0;
                    tipoSocioComboBox.Enabled = false;
                    tipoSocioComboBox.SelectedIndex = 0;
                    nomeCompletoSocioTextBox.Enabled = false;
                    nomeCompletoSocioTextBox.Clear();
                    tipoRegistroComboBox.Enabled = false;
                    tipoRegistroComboBox.SelectedIndex = 0;
                    descricaoRegistroSocioTextBox.Enabled = false;
                    descricaoRegistroSocioTextBox.Clear();
                }

                if(admPanelCheckBox.Checked == true)
                {
                    empresaAdmComboBox.SelectedIndex = 0;
                    funcionarioAdmcomboBox.Enabled = false;
                    empresaAdmComboBox.SelectedIndex = 0;
                    funcionarioAdmcomboBox.SelectedIndex = 0;
                    nomeCompletoFuncionarioAdmTextBox.Clear();
                    setorFuncionarioAdmtextBox.Clear();
                    nivelHierarquicoFuncionarioAdmTextBox.Clear();
                }
                    MessageBox.Show("Dados Salvos com Sucesso");
            }
            else
            {
                MessageBox.Show("Por Favor escolha o tipo de Cadastro que deseja realizar.");
            }
        }
    }
}
