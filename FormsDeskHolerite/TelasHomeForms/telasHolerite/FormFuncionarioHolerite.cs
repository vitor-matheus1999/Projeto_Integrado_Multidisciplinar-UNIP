using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasHolerite
{
    public partial class FormFuncionarioHolerite : Form
    {
        int idFuncionario;
        Funcionario funcionario = new Funcionario();
        Setor setor = new Setor();
        Salario salario = new Salario();
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsBancoDadosSalario bdSalario = new ClsBancoDadosSalario();

        public FormFuncionarioHolerite()
        {
            InitializeComponent();
        }

        public FormFuncionarioHolerite(int idFuncionarioEscolhido)
        {
            idFuncionario = idFuncionarioEscolhido;
            InitializeComponent();
            funcionario = bdFuncionario.GetInformacaoFuncionario(idFuncionario);
            nomeFuncionarioTextBox.Text = funcionario.GetNomeFuncionario;
            dataAdmissaoTextBox.Text = funcionario.GetDataAdmissao.Date.ToString();
            dataNascimentoTextBox.Text = funcionario.GetDataNascimento.Date.ToString();
            cpfTextBox.Text = funcionario.GetCpfFuncionario;
            empresaContratanteTextBox.Text = bdEmpresa.GetNomeEmpresa(funcionario.GetIdEmpresa);
            #region Genero Funcionario
            if (funcionario.GetGeneroFuncionario == "MT")
            {generoFuncionarioTextBox.Text = "Mulher Trans";
            }else if(funcionario.GetGeneroFuncionario == "HT")
            {generoFuncionarioTextBox.Text = "Homen Trans";
            }else if (funcionario.GetGeneroFuncionario == "MC")
            {generoFuncionarioTextBox.Text = "Mulher Cis";
            }else if (funcionario.GetGeneroFuncionario == "HC")
            {generoFuncionarioTextBox.Text = "Homem Cis";
            }else if (funcionario.GetGeneroFuncionario == "NB")
            {generoFuncionarioTextBox.Text = "Não Binárie";
            }else if (funcionario.GetGeneroFuncionario == "NE")
            {generoFuncionarioTextBox.Text = "Não Específicado";
            }
            #endregion

            setor = bdSetor.GetDadosSetor(funcionario.GetIdSetor);
            setorFuncionarioTextBox.Text = setor.GetNomeSetor;
            nivelHierarquicoFuncionarioTextBox.Text = setor.GetHierarquia;
            periodoTrabalhoTextBox.Text = setor.GetPeriodoTrabalho;
            escalaTrabalhoTextBox.Text = setor.GetEscalaTrabalho;
            cargaHorariaTextBox.Text = setor.GetCargaHoraria.ToString();
            salarioGanhoHorasTextBox.Text = setor.GetSalarioGanhoHora.ToString();
            salarioGanhoDiaTextBox.Text = setor.GetSalarioGanhoDia.ToString();

            funcionario = bdFuncionario.GetInformacaoFuncionarioEndereco(idFuncionario);
            ruaFuncionarioTextBox.Text = funcionario.GetRua;
            numeroMoradiaFuncionarioTextBox.Text = funcionario.GetNumeroMoradia;
            bairroFuncionarioTextBox.Text = funcionario.GetBairro;
            cepTextBox.Text = funcionario.GetCepResidencia;
            cidadeFuncionarioTextBox.Text = funcionario.GetCidadeMoradiaFuncionario;

            salario = bdSalario.GetSalario(setor.GetIdSalario);
            salarioBrutoTextBox.Text = salario.GetSalarioBruto.ToString();
            salarioLiquidoTextBox.Text = salario.GetSalarioLiquido.ToString();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FecharJanelaIconButton_Click(object sender, EventArgs e)
        {

        }

        private void clsCircularBoxIcon1_Click(object sender, EventArgs e)
        {
            bdFuncionario.SetHorasNaoTrabalhadas(idFuncionario, horasNaoTrabalhadasTextBox.Text);
            bdFuncionario.SetHorasExtras(idFuncionario, horasExtrasTextBox.Text);
        }
    }
}
