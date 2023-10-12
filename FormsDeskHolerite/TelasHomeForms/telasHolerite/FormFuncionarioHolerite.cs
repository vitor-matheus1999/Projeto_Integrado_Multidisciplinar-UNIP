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
using System.Windows.Media.Media3D;

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

        private void addHorasExtrasNaoTrabalhadasButton_Click(object sender, EventArgs e)
        {

            var horasExtrasForms = float.Parse(horasExtrasTextBox.Text);
        
            if(bdFuncionario.GetHorasExtras(idFuncionario) == 0)
            {

                bdFuncionario.SetHorasNaoTrabalhadas(idFuncionario, float.Parse( horasNaoTrabalhadasTextBox.Text));
                bdFuncionario.SetHorasExtras(idFuncionario, float.Parse(horasExtrasTextBox.Text));
                salarioDevendoTextBox.Text = (float.Parse(salarioGanhoHorasTextBox.Text) * horasExtrasForms ).ToString();
                MessageBox.Show("Horas Extras salvas com sucesso");
            }

            if (bdFuncionario.GetHorasExtras(idFuncionario) > 0)
            {
                MessageBox.Show("Parece que este funcionário contém horas extras pendentes, logo as horas extras adicionadas atualmentes se somarão com as anteriores", "AVISO");
                var horasExtrasSalvasNoBancoDados = float.Parse(bdFuncionario.GetHorasExtras(idFuncionario).ToString());
                var somaHorasExtras = horasExtrasForms + horasExtrasSalvasNoBancoDados;
                bdFuncionario.SetHorasNaoTrabalhadas(idFuncionario, float.Parse(horasNaoTrabalhadasTextBox.Text));
                bdFuncionario.SetHorasExtras(idFuncionario, somaHorasExtras);
                salarioDevendoTextBox.Text = (float.Parse(salarioGanhoHorasTextBox.Text) * somaHorasExtras).ToString();
                bdFuncionario.SetSalarioSeraAcrescentadoDevidoHorasExtras(idFuncionario, float.Parse(salarioDevendoTextBox.Text));
            }
            

        }

        private void fecharHoleriteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar e zerar as horas extras desse funcionário ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdFuncionario.SetHorasExtras(idFuncionario, 0);
                MessageBox.Show("As horas extras do funcionário foram zeradas com sucesso");
                FormHolerite.holeriteTabControl.TabPages.Remove(FormHolerite.holeriteTabControl.SelectedTab);
                bdFuncionario.SetHoleriteFinalizado(idFuncionario, 1);
            }
            else
            {
                MessageBox.Show("O funcionário atualmente contém  " + bdFuncionario.GetHorasExtras(idFuncionario) + " horas extras salvas");
                FormHolerite.holeriteTabControl.TabPages.Remove(FormHolerite.holeriteTabControl.SelectedTab);
                bdFuncionario.SetHoleriteFinalizado(idFuncionario, 1);
            }
        }

        private void salvarHoleriteButton_Click(object sender, EventArgs e)
        {
            FormHolerite.holeriteTabControl.TabPages.Remove(FormHolerite.holeriteTabControl.SelectedTab);
            MessageBox.Show("Dados Salvos");
        }
    }
}
