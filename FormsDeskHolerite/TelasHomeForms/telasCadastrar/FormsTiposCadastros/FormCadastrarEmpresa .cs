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
using PIM4___WebHolerite.Models.Negócios;
using PIM4___WebHolerite.Models.Banco_de_Dados;

namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarEmpresa : Form
    {

        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        Empresa empresa = new Empresa();
        private int i;

        public FormCadastrarEmpresa()
        {
            InitializeComponent();
            #region Tabela Contato Empresa Um
            DataTable tabela = new DataTable();
            DataRow itemLinha = tabela.NewRow();
            tabela.Columns.Add("Tipo-Contato");
            tabela.Rows.Add("Escolha o tipo de Contato");
            tabela.Rows.Add("E-mail Empresarial");
            tabela.Rows.Add("E-mail Pessoal");
            tabela.Rows.Add("Telefone Celular");
            tabela.Rows.Add("Telefone Residêncial");
            tabela.Rows.Add("Rede Social");
            tipoContatoEmpresaComboBox.DataSource = tabela;
            tipoContatoEmpresaComboBox.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Empresa Dois
            DataTable tabelaDois = new DataTable();
            DataRow itemLinhaDois = tabelaDois.NewRow();
            tabelaDois.Columns.Add("Tipo-Contato");
            tabelaDois.Rows.Add("Escolha o tipo de Contato");
            tabelaDois.Rows.Add("E-mail Empresarial");
            tabelaDois.Rows.Add("E-mail Pessoal");
            tabelaDois.Rows.Add("Telefone Celular");
            tabelaDois.Rows.Add("Telefone Residêncial");
            tabelaDois.Rows.Add("Rede Social");
            tipoContatoEmpresaComboBoxDois.DataSource = tabelaDois;
            tipoContatoEmpresaComboBoxDois.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Empresa Tres
            DataTable tabelaTres = new DataTable();
            DataRow itemLinhaTres = tabelaTres.NewRow();
            tabelaTres.Columns.Add("Tipo-Contato");
            tabelaTres.Rows.Add("Escolha o tipo de Contato");
            tabelaTres.Rows.Add("E-mail Empresarial");
            tabelaTres.Rows.Add("E-mail Pessoal");
            tabelaTres.Rows.Add("Telefone Celular");
            tabelaTres.Rows.Add("Telefone Residêncial");
            tabelaTres.Rows.Add("Rede Social");
            tipoContatoEmpresaComboBoxDois.DataSource = tabelaTres;
            tipoContatoEmpresaComboBoxDois.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Empresa Quatro
            DataTable tabelaQuatro = new DataTable();
            DataRow itemLinhaQuatro = tabelaQuatro.NewRow();
            tabelaQuatro.Columns.Add("Tipo-Contato");
            tabelaQuatro.Rows.Add("Escolha o tipo de Contato");
            tabelaQuatro.Rows.Add("E-mail Empresarial");
            tabelaQuatro.Rows.Add("E-mail Pessoal");
            tabelaQuatro.Rows.Add("Telefone Celular");
            tabelaQuatro.Rows.Add("Telefone Residêncial");
            tabelaQuatro.Rows.Add("Rede Social");
            tipoContatoEmpresaComboBoxTres.DataSource = tabelaQuatro;
            tipoContatoEmpresaComboBoxTres.DisplayMember = "Tipo-Contato";
            #endregion
            #region Tabela Contato Empresa Cinco
            DataTable tabelaCinco = new DataTable();
            DataRow itemLinhaCinco = tabela.NewRow();
            tabelaCinco.Columns.Add("Tipo-Contato");
            tabelaCinco.Rows.Add("Escolha o tipo de Contato");
            tabelaCinco.Rows.Add("E-mail Empresarial");
            tabelaCinco.Rows.Add("E-mail Pessoal");
            tabelaCinco.Rows.Add("Telefone Celular");
            tabelaCinco.Rows.Add("Telefone Residêncial");
            tabelaCinco.Rows.Add("Rede Social");
            tipoContatoEmpresaComboBoxQuatro.DataSource = tabelaCinco;
            tipoContatoEmpresaComboBoxQuatro.DisplayMember = "Tipo-Contato";
            #endregion
        }


        private void clsCircularBoxIcon1_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                label20.Visible = true;
                contatoEmpresaTextBoxDois.Enabled = true;
                contatoEmpresaTextBoxDois.Visible = true;
                label19.Visible = true;
                tipoContatoEmpresaComboBoxDois.Enabled = true;
                tipoContatoEmpresaComboBoxDois.Visible = true;

            }
            else if (i == 2)
            {
                label22.Visible = true;
                contatoEmpresaTextBoxTres.Enabled = true;
                contatoEmpresaTextBoxTres.Visible = true;
                label21.Visible = true;
                tipoContatoEmpresaComboBoxTres.Enabled = true;
                tipoContatoEmpresaComboBoxTres.Visible = true;
            }
            else if (i == 3)
            {
                label24.Visible = true;
                contatoEmpresaTextBoxQuatro.Enabled = true;
                contatoEmpresaTextBoxQuatro.Visible = true;
                label23.Visible = true;
                tipoContatoEmpresaComboBoxQuatro.Enabled = true;
                tipoContatoEmpresaComboBoxQuatro.Visible = true;
            }
            else if (i == 4)
            {
                label26.Visible = true;
                contatoEmpresaTextBoxCinco.Enabled = true;
                contatoEmpresaTextBoxCinco.Visible = true;
                label25.Visible = true;
                tipoContatoEmpresaComboBoxCinco.Enabled = true;
                tipoContatoEmpresaComboBoxCinco.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void salvarInfoEmpresaButton_Click(object sender, EventArgs e)
        {
            bdEmpresa.SetDadosEmpresa(nomeEmpresarialFantasiaTextBox.Text, cnaeTextBox.Text, cnpjTextBox.Text, situacaoCadastralComboBox.Text, naturezaJuridicaTextBox.Text, this.dataAberturaEmpresaDateTimePicker.Text, atividadesEconomicasTextBox.Text);
            bdEmpresa.GetInformacaoEmpresa();
            var idEmpresa = bdEmpresa.GetIdEmpresa(cnaeTextBox.Text, cnpjTextBox.Text);
            bdEmpresa.SetDadosEmpresa(idEmpresa, enderecoTextBox.Text, numResidenciaTextBox.Text, bairroTextBox.Text, cepTextBox.Text, cidadeTextBox.Text);
            #region Contatos  Empresa     
            bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBox.Text, contatoEmpresaTextBox.Text);
            if (tipoContatoEmpresaComboBoxDois.Enabled == true && contatoEmpresaTextBoxDois.Enabled == true)
            {
                bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxDois.Text, contatoEmpresaTextBoxDois.Text);
            }
            else if (tipoContatoEmpresaComboBoxTres.Enabled == true && contatoEmpresaTextBoxTres.Enabled == true)
            {
                bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxTres.Text, contatoEmpresaTextBoxTres.Text);
            }
            else if (tipoContatoEmpresaComboBoxQuatro.Enabled == true && contatoEmpresaTextBoxQuatro.Enabled == true)
            {
                bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxQuatro.Text, contatoEmpresaTextBoxQuatro.Text);
            }
            else if (tipoContatoEmpresaComboBoxCinco.Enabled == true && contatoEmpresaTextBoxCinco.Enabled == true)
            {
                bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxCinco.Text, contatoEmpresaTextBoxCinco.Text);
            }
            #endregion
        }
    }
}
