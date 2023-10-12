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
            situacaoCadastralComboBox.SelectedIndex = 0;
            tipoContatoEmpresaComboBox.SelectedIndex = 0;
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
                tipoContatoEmpresaComboBoxDois.SelectedIndex = 0;

            }
            else if (i == 2)
            {
                label22.Visible = true;
                contatoEmpresaTextBoxTres.Enabled = true;
                contatoEmpresaTextBoxTres.Visible = true;
                label21.Visible = true;
                tipoContatoEmpresaComboBoxTres.Enabled = true;
                tipoContatoEmpresaComboBoxTres.Visible = true;
                tipoContatoEmpresaComboBoxTres.SelectedIndex = 0;
            }
            else if (i == 3)
            {
                label24.Visible = true;
                contatoEmpresaTextBoxQuatro.Enabled = true;
                contatoEmpresaTextBoxQuatro.Visible = true;
                label23.Visible = true;
                tipoContatoEmpresaComboBoxQuatro.Enabled = true;
                tipoContatoEmpresaComboBoxQuatro.Visible = true;
                tipoContatoEmpresaComboBoxQuatro.SelectedIndex = 0;
            }
            else if (i == 4)
            {
                label26.Visible = true;
                contatoEmpresaTextBoxCinco.Enabled = true;
                contatoEmpresaTextBoxCinco.Visible = true;
                label25.Visible = true;
                tipoContatoEmpresaComboBoxCinco.Enabled = true;
                tipoContatoEmpresaComboBoxCinco.Visible = true;
                tipoContatoEmpresaComboBoxCinco.SelectedIndex = 0;
            }
            else
            {
                return;
            }
        }

        private void salvarInfoEmpresaButton_Click(object sender, EventArgs e)
        {
            bool validacaoCadastroEmpresa = false;
            bool validacaoCadastroEnderecoEmpresa = false;
            bool validacaoCadastroContatoEmpresa = false;

            #region Tratamento Campos 
            if (nomeEmpresarialFantasiaTextBox.Text == null || cnaeTextBox.Text == null || naturezaJuridicaTextBox.Text == null || cnpjTextBox.Text == null || situacaoCadastralComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor preencha os campos em branco");
                return;
            }
            else if (enderecoTextBox.Text == null || numResidenciaTextBox.Text == null || cepTextBox.Text == null || bairroTextBox.Text == null || cidadeTextBox.Text == null)
            {
                MessageBox.Show("Por favor preencha os campos em branco");
                return;
            }
            else if (tipoContatoEmpresaComboBox.SelectedIndex == 0 || contatoEmpresaTextBox.Text == null || tipoContatoEmpresaComboBoxDois.Enabled == true && tipoContatoEmpresaComboBoxDois.SelectedIndex == 0 || contatoEmpresaTextBoxDois.Enabled == true && contatoEmpresaTextBoxDois.Text == null || tipoContatoEmpresaComboBoxTres.Enabled == true && tipoContatoEmpresaComboBoxTres.SelectedIndex == 0 || contatoEmpresaTextBoxTres.Enabled == true && contatoEmpresaTextBoxTres.Text == null || tipoContatoEmpresaComboBoxQuatro.Enabled == true && tipoContatoEmpresaComboBoxQuatro.SelectedIndex == 0 || contatoEmpresaTextBoxQuatro.Enabled == true && contatoEmpresaTextBoxQuatro.Text == null || tipoContatoEmpresaComboBoxCinco.Enabled == true && tipoContatoEmpresaComboBoxCinco.SelectedIndex == 0 || contatoEmpresaTextBoxCinco.Enabled == true && contatoEmpresaTextBoxCinco.Text == null)
            {
                MessageBox.Show("Por favor preencha os campos em branco");
                return;
            }
            #endregion

            validacaoCadastroEmpresa = bdEmpresa.SetDadosEmpresa(nomeEmpresarialFantasiaTextBox.Text, cnaeTextBox.Text, cnpjTextBox.Text, situacaoCadastralComboBox.Text, naturezaJuridicaTextBox.Text, this.dataAberturaEmpresaDateTimePicker.Text, atividadesEconomicasTextBox.Text);
            bdEmpresa.GetInformacaoEmpresa();
            var idEmpresa = bdEmpresa.GetIdEmpresa(cnaeTextBox.Text, cnpjTextBox.Text);
            validacaoCadastroEnderecoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, enderecoTextBox.Text, numResidenciaTextBox.Text, bairroTextBox.Text, cepTextBox.Text, cidadeTextBox.Text);
            #region Contatos  Empresa     
            validacaoCadastroContatoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBox.Text, contatoEmpresaTextBox.Text);
            if (tipoContatoEmpresaComboBoxDois.Enabled == true && contatoEmpresaTextBoxDois.Enabled == true)
            {
                validacaoCadastroContatoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxDois.Text, contatoEmpresaTextBoxDois.Text);
            }
            else if (tipoContatoEmpresaComboBoxTres.Enabled == true && contatoEmpresaTextBoxTres.Enabled == true)
            {
                validacaoCadastroContatoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxTres.Text, contatoEmpresaTextBoxTres.Text);
            }
            else if (tipoContatoEmpresaComboBoxQuatro.Enabled == true && contatoEmpresaTextBoxQuatro.Enabled == true)
            {
                validacaoCadastroContatoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxQuatro.Text, contatoEmpresaTextBoxQuatro.Text);
            }
            else if (tipoContatoEmpresaComboBoxCinco.Enabled == true && contatoEmpresaTextBoxCinco.Enabled == true)
            {
                validacaoCadastroContatoEmpresa = bdEmpresa.SetDadosEmpresa(idEmpresa, tipoContatoEmpresaComboBoxCinco.Text, contatoEmpresaTextBoxCinco.Text);
            }
            #endregion

            if (validacaoCadastroEmpresa == true && validacaoCadastroEnderecoEmpresa == true && validacaoCadastroContatoEmpresa == true)
            {
                nomeEmpresarialFantasiaTextBox.Text = "";
                cnaeTextBox.Text = "";
                naturezaJuridicaTextBox.Text = "";
                dataAberturaEmpresaDateTimePicker.Value = DateTime.Now;
                cnpjTextBox.Text = "";
                situacaoCadastralComboBox.SelectedIndex = 0;

                enderecoTextBox.Text = "";
                numResidenciaTextBox.Text = ""; 
                cepTextBox.Text = "";
                bairroTextBox.Text = "";
                cidadeTextBox.Text = "";

                label20.Visible = false;
                contatoEmpresaTextBoxDois.Enabled = false;
                contatoEmpresaTextBoxDois.Visible = false;
                label19.Visible = false;
                tipoContatoEmpresaComboBoxDois.Enabled = false;
                tipoContatoEmpresaComboBoxDois.Visible = false;

                label22.Visible = false;
                contatoEmpresaTextBoxTres.Enabled = false;
                contatoEmpresaTextBoxTres.Visible = false;
                label21.Visible = false;
                tipoContatoEmpresaComboBoxTres.Enabled = false;
                tipoContatoEmpresaComboBoxTres.Visible = false;

                label24.Visible = false;
                contatoEmpresaTextBoxQuatro.Enabled = false;
                contatoEmpresaTextBoxQuatro.Visible = false;
                label23.Visible = false;
                tipoContatoEmpresaComboBoxQuatro.Enabled = false;
                tipoContatoEmpresaComboBoxQuatro.Visible = false;

                label26.Visible = false;
                contatoEmpresaTextBoxCinco.Enabled = false;
                contatoEmpresaTextBoxCinco.Visible = false;
                label25.Visible = false;
                tipoContatoEmpresaComboBoxCinco.Enabled = false;
                tipoContatoEmpresaComboBoxCinco.Visible = false;

                MessageBox.Show("Dados Salvos com Sucesso");
            }
        }
    }
}
