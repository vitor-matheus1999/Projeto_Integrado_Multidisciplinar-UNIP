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
    public partial class FormCadastrarFuncionario : Form
    {
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        Funcionario funcionario = new Funcionario();
        int i = 0;
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
            bdFuncionario.GetEmpresasComboBox(empresaFuncionarioComboBox);
            sexoComboBox.SelectedIndex = 0;
            #region Tabela Contato Um
            DataTable tabela = new DataTable();
            DataRow itemLinha = tabela.NewRow();
            tabela.Columns.Add("Tipo-Contato");
            tabela.Rows.Add("Escolha o tipo de Contato");
            tabela.Rows.Add("E-mail Empresarial");
            tabela.Rows.Add("E-mail Pessoal");
            tabela.Rows.Add("Telefone Celular");
            tabela.Rows.Add("Telefone Residêncial");
            tabela.Rows.Add("Rede Social");
            tipoContatoComboBox.DataSource = tabela;
            tipoContatoComboBox.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Dois
            DataTable tabelaDois = new DataTable();
            DataRow itemLinhaDois = tabelaDois.NewRow();
            tabelaDois.Columns.Add("Tipo-Contato");
            tabelaDois.Rows.Add("Escolha o tipo de Contato");
            tabelaDois.Rows.Add("E-mail Empresarial");
            tabelaDois.Rows.Add("E-mail Pessoal");
            tabelaDois.Rows.Add("Telefone Celular");
            tabelaDois.Rows.Add("Telefone Residêncial");
            tabelaDois.Rows.Add("Rede Social");
            tipoContatoComboBoxDois.DataSource = tabelaDois;
            tipoContatoComboBoxDois.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Tres
            DataTable tabelaTres = new DataTable();
            DataRow itemLinhaTres = tabelaTres.NewRow();
            tabelaTres.Columns.Add("Tipo-Contato");
            tabelaTres.Rows.Add("Escolha o tipo de Contato");
            tabelaTres.Rows.Add("E-mail Empresarial");
            tabelaTres.Rows.Add("E-mail Pessoal");
            tabelaTres.Rows.Add("Telefone Celular");
            tabelaTres.Rows.Add("Telefone Residêncial");
            tabelaTres.Rows.Add("Rede Social");
            tipoContatoComboBoxDois.DataSource = tabelaTres;
            tipoContatoComboBoxDois.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Quatro
            DataTable tabelaQuatro = new DataTable();
            DataRow itemLinhaQuatro = tabelaQuatro.NewRow();
            tabelaQuatro.Columns.Add("Tipo-Contato");
            tabelaQuatro.Rows.Add("Escolha o tipo de Contato");
            tabelaQuatro.Rows.Add("E-mail Empresarial");
            tabelaQuatro.Rows.Add("E-mail Pessoal");
            tabelaQuatro.Rows.Add("Telefone Celular");
            tabelaQuatro.Rows.Add("Telefone Residêncial");
            tabelaQuatro.Rows.Add("Rede Social");
            tipoContatoComboBoxTres.DataSource = tabelaQuatro;
            tipoContatoComboBoxTres.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Cinco
            DataTable tabelaCinco = new DataTable();
            DataRow itemLinhaCinco = tabela.NewRow();
            tabelaCinco.Columns.Add("Tipo-Contato");
            tabelaCinco.Rows.Add("Escolha o tipo de Contato");
            tabelaCinco.Rows.Add("E-mail Empresarial");
            tabelaCinco.Rows.Add("E-mail Pessoal");
            tabelaCinco.Rows.Add("Telefone Celular");
            tabelaCinco.Rows.Add("Telefone Residêncial");
            tabelaCinco.Rows.Add("Rede Social");
            tipoContatoComboBoxQuatro.DataSource = tabelaCinco;
            tipoContatoComboBoxQuatro.DisplayMember = "Tipo-Contato";
            #endregion
        }
        private void addContatoFuncionarioButton_Click(object sender, EventArgs e)
        {
            i++;
            if(i == 1)
            {
                label20.Visible = true;
                contatoTextBoxDois.Enabled = true;
                contatoTextBoxDois.Visible = true;
                label19.Visible = true;
                tipoContatoComboBoxDois.Enabled = true;
                tipoContatoComboBoxDois.Visible = true;

            }
            else if (i == 2)
            {
                label22.Visible = true;
                contatoTextBoxTres.Enabled = true;
                contatoTextBoxTres.Visible = true;
                label21.Visible = true;
                tipoContatoComboBoxTres.Enabled = true;
                tipoContatoComboBoxTres.Visible = true;
            }
            else if (i == 3)
            {
                label24.Visible = true;
                contatoTextBoxQuatro.Enabled = true;
                contatoTextBoxQuatro.Visible = true;
                label23.Visible = true;
                tipoContatoComboBoxQuatro.Enabled = true;
                tipoContatoComboBoxQuatro.Visible = true;
            }
            else if (i == 4)
            {
                label26.Visible = true;
                contatoTextBoxCinco.Enabled = true;
                contatoTextBoxCinco.Visible = true;
                label25.Visible = true;
                tipoContatoComboBoxCinco.Enabled = true;
                tipoContatoComboBoxCinco.Visible = true;
            }
            else
            {
                return;
            }
        }
        private void empresaFuncionarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(empresaFuncionarioComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                setorFuncionarioComboBox.Enabled = false;
                setorFuncionarioComboBox.Enabled = true;
            }
        }
        private void setorFuncionarioComboBox_EnabledChanged(object sender, EventArgs e)
        {

            bdFuncionario.GetSetoresComboBox(setorFuncionarioComboBox, Convert.ToInt32(empresaFuncionarioComboBox.SelectedValue) );
        }
        private void setorFuncionarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setorFuncionarioComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                nivelHierarquicoComboBox.Enabled = false;
                nivelHierarquicoComboBox.Enabled = true;
            }
        }
        private void nivelHierarquicoComboBox_EnabledChanged(object sender, EventArgs e)
        {
            bdFuncionario.GetHierarquiaComboBox(nivelHierarquicoComboBox, setorFuncionarioComboBox.Text);
        }
        private void salvarInfoFuncionario_Click(object sender, EventArgs e)
        {
            bool dadosPessoalFuncionario;
            bool dadosEnderecoFuncionario;
            bool dadosContatoFuncionario = false;

            #region Genero Funcionario
            if (sexoComboBox.Text.Contains("Mulher Trans"))
            {
                funcionario.SetGeneroFuncionario = "MT";
            }else if (sexoComboBox.Text.Contains("Homem Trans"))
            {
                funcionario.SetGeneroFuncionario = "HT";
            }else if (sexoComboBox.Text.Contains("Homem Cis"))
            {
                funcionario.SetGeneroFuncionario = "HC";
            }
            else if (sexoComboBox.Text.Contains("Mulher Cis"))
            {
                funcionario.SetGeneroFuncionario = "MC";
            }
            else if (sexoComboBox.Text.Contains("Não Binário"))
            {
                funcionario.SetGeneroFuncionario = "NB";
            }
            else if (sexoComboBox.Text.Contains("Prefiro não responder"))
            {
                funcionario.SetGeneroFuncionario = "NE";
            }
            #endregion
            dadosPessoalFuncionario = bdFuncionario.SetDadosFuncionario(Int32.Parse(empresaFuncionarioComboBox.SelectedValue.ToString()), Int32.Parse(nivelHierarquicoComboBox.SelectedValue.ToString()), nomeTextBox.Text, this.dataNascimentoDateTimePicker.Text, this.dataAdmissaoDateTimePicker.Text, funcionario.GetGeneroFuncionario, cpfTextBox.Text);
            bdFuncionario.GetInformacaoFuncionario();
            var idFuncionario = bdFuncionario.GetIdFuncionario(Int32.Parse(empresaFuncionarioComboBox.SelectedValue.ToString()), Int32.Parse(setorFuncionarioComboBox.SelectedValue.ToString()), nomeTextBox.Text, cpfTextBox.Text);
            dadosEnderecoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, enderecoTextBox.Text, numResidenciaTextBox.Text, bairroTextBox.Text, cepTextBox.Text, cidadeTextBox.Text);
            #region Contatos       
            dadosContatoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, tipoContatoComboBox.Text, contatoTextBox.Text);
            if (tipoContatoComboBoxDois.Enabled == true && contatoTextBoxDois.Enabled == true)
            {
                dadosContatoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, tipoContatoComboBoxDois.Text, contatoTextBoxDois.Text);
            }else if (tipoContatoComboBoxTres.Enabled == true && contatoTextBoxTres.Enabled == true)
            {
                dadosContatoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, tipoContatoComboBoxTres.Text, contatoTextBoxTres.Text);
            }else if (tipoContatoComboBoxQuatro.Enabled == true && contatoTextBoxQuatro.Enabled == true)
            {
                dadosContatoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, tipoContatoComboBox.Text, contatoTextBox.Text);
            }else if (tipoContatoComboBoxQuatro.Enabled == true && contatoTextBoxQuatro.Enabled == true)
            {
                dadosContatoFuncionario = bdFuncionario.SetDadosFuncionario(idFuncionario, tipoContatoComboBoxQuatro.Text, contatoTextBoxQuatro.Text);
            }
            #endregion

            if(dadosPessoalFuncionario == true && dadosEnderecoFuncionario == true && dadosContatoFuncionario == true)
            {
                nomeTextBox.Clear();
                cpfTextBox.Clear();
                dataNascimentoDateTimePicker.
                sexoComboBox.SelectedIndex = 0;
                empresaFuncionarioComboBox.SelectedIndex = 0;
                setorFuncionarioComboBox.SelectedIndex = 0;
                nivelHierarquicoComboBox.SelectedIndex = 0;

                enderecoTextBox.Clear();
                numResidenciaTextBox.Clear();
                cepTextBox.Clear();
                bairroTextBox.Clear();
                cidadeTextBox.Clear();

                tipoContatoComboBox.SelectedIndex = 0;
                contatoTextBox.Clear();

                label20.Visible = false;
                contatoTextBoxDois.Enabled = false;
                contatoTextBoxDois.Visible = false;
                label19.Visible = false;
                tipoContatoComboBoxDois.Enabled = false;
                tipoContatoComboBoxDois.Visible = false;
      
                label22.Visible = false;
                contatoTextBoxTres.Enabled = false;
                contatoTextBoxTres.Visible = false;
                label21.Visible = false;
                tipoContatoComboBoxTres.Enabled = false;
                tipoContatoComboBoxTres.Visible = false;
           
                label24.Visible = false;
                contatoTextBoxQuatro.Enabled = false;
                contatoTextBoxQuatro.Visible = false;
                label23.Visible = false;
                tipoContatoComboBoxQuatro.Enabled = false;
                tipoContatoComboBoxQuatro.Visible = false;
           
                label26.Visible = false;
                contatoTextBoxCinco.Enabled = false;
                contatoTextBoxCinco.Visible = false;
                label25.Visible = false;
                tipoContatoComboBoxCinco.Enabled = false;
                tipoContatoComboBoxCinco.Visible = false;

                MessageBox.Show("Dados Salvos com Sucesso");
            }

        }
    }
}
