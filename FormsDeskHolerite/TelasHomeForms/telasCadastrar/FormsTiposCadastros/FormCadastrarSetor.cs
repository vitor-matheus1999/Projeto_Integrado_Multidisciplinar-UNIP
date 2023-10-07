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
using System.Windows.Media;

namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarSetor : Form
    {
        Setor setor = new Setor();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSalario bdSalario= new ClsBancoDadosSalario();

        public FormCadastrarSetor()
        {
            InitializeComponent();
            empresaPertencenteSetorComboBox.TabIndex = 0;
            salarioSetorComboBox.TabIndex = 0;
            escalaTrabalhoComboBox.TabIndex = 0;
            nivelHirarquicoComboBox.TabIndex = 0;
            periodoTrabalhoComboBox.TabIndex = 0;
            cargaHorariaComboBox.TabIndex = 0;
        }
        private void FormCadastrarSetor_Load(object sender, EventArgs e)
        {
            bdEmpresa.GetEmpresasComboBox(empresaPertencenteSetorComboBox);
            #region Tabela Hierarquia Funcionario
            DataTable tabelaHierarquia = new DataTable();
            DataRow itemLinhaHierarquia = tabelaHierarquia.NewRow();
            tabelaHierarquia.Columns.Add("Hierarquia");
            tabelaHierarquia.Rows.Add("Escolha o Nível Hierarquico");
            tabelaHierarquia.Rows.Add("Estágio");
            tabelaHierarquia.Rows.Add("Junior");
            tabelaHierarquia.Rows.Add("Pleno");
            tabelaHierarquia.Rows.Add("Senior");
            nivelHirarquicoComboBox.DataSource = tabelaHierarquia;
            nivelHirarquicoComboBox.DisplayMember = "Hierarquia";
            #endregion
            #region Tabela Periodo de Trabalho
            DataTable tabelaPeriodoTrabalho = new DataTable();
            DataRow itemLinhaPeriodoTrabalho = tabelaPeriodoTrabalho.NewRow();
            tabelaPeriodoTrabalho.Columns.Add("Periodo de Trabalho");
            tabelaPeriodoTrabalho.Rows.Add("Escolha o Período de Trabalho");
            tabelaPeriodoTrabalho.Rows.Add("Integral");
            tabelaPeriodoTrabalho.Rows.Add("Manhã/Tarde");
            tabelaPeriodoTrabalho.Rows.Add("Tarde/Noite");
            tabelaPeriodoTrabalho.Rows.Add("Madrugada");
            periodoTrabalhoComboBox.DataSource = tabelaPeriodoTrabalho;
            periodoTrabalhoComboBox.DisplayMember = "Periodo de Trabalho";
            #endregion
            #region Tabela Carga Horária
            DataTable tabelaCargaHoraria = new DataTable();
            DataRow itemLinhaCargaHoraria = tabelaCargaHoraria.NewRow();
            tabelaCargaHoraria.Columns.Add("Carga Horária");
            tabelaCargaHoraria.Rows.Add("Escolha a Carga Horária");
            tabelaCargaHoraria.Rows.Add("6:00:00");
            tabelaCargaHoraria.Rows.Add("8:00:00");
            tabelaCargaHoraria.Rows.Add("12:00:00");
            cargaHorariaComboBox.DataSource = tabelaCargaHoraria;
            cargaHorariaComboBox.DisplayMember = "Carga Horária";
            #endregion
        }
        private void salarioSetorComboBox_EnabledChanged(object sender, EventArgs e)
        {
            bdSalario.GetSalariosComboBox(salarioSetorComboBox, Convert.ToInt32(empresaPertencenteSetorComboBox.SelectedValue));
        }
        private void empresaPertencenteSetorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(empresaPertencenteSetorComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                salarioSetorComboBox.Enabled = false;
                salarioSetorComboBox.Enabled = true;
            }
        }     
        private void salvarInfoSetorButton_Click(object sender, EventArgs e)
        {
            decimal totalSalarioGanhoUmaHora = 0;
            decimal totalSalarioGanhoUmDia= 0;
            int valorCargaHorariaTrabalho = 0;
            int diasMesSemFinalSemana = 0;
            int diasMesSemDomingo = 0;

            if (empresaPertencenteSetorComboBox.SelectedIndex == 0 || nomeSetorTextBox.Text == null || salarioSetorComboBox.SelectedIndex == 0 || nivelHirarquicoComboBox.SelectedIndex == 0 || periodoTrabalhoComboBox.SelectedIndex == 0 || cargaHorariaComboBox.SelectedIndex == 0 || escalaTrabalhoComboBox.SelectedIndex == 0 || funcaoSetorTextBox.Text == null)
            {
                MessageBox.Show("Por favor preencha os campos em branco");
                return;
            }

            for (var i = 0; i < cargaHorariaComboBox.Text.ToCharArray().Length; i++)
            {
                if ( Char.IsDigit(cargaHorariaComboBox.Text.ToList()[i]) == true)
                {
                    if(Int32.Parse(cargaHorariaComboBox.Text.ToList()[i].ToString()) > 0)
                    {
                        valorCargaHorariaTrabalho += Int32.Parse(cargaHorariaComboBox.Text.ToCharArray()[i].ToString());
                    }
                }
            }

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                DateTime thisDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i);
                if (thisDay.DayOfWeek != DayOfWeek.Sunday && thisDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    diasMesSemFinalSemana += 1;
                }
                if (thisDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasMesSemDomingo += 1;
                }
            }

            switch (escalaTrabalhoComboBox.Text)
            {
                case "5/2":
                    var resultado5DiasTrabalho = (5 * valorCargaHorariaTrabalho) * diasMesSemFinalSemana;
                    totalSalarioGanhoUmaHora = (decimal)System.Math.Round(decimal.Parse(salarioSetorComboBox.Text) / resultado5DiasTrabalho, 2);
                    totalSalarioGanhoUmDia =  totalSalarioGanhoUmaHora * valorCargaHorariaTrabalho;
                    break;
                case "6/1":
                    var resultado6DiasTrabalho = (6 * valorCargaHorariaTrabalho) * diasMesSemFinalSemana;
                    totalSalarioGanhoUmaHora = (decimal)System.Math.Round(decimal.Parse(salarioSetorComboBox.Text) / resultado6DiasTrabalho, 2 );
                    totalSalarioGanhoUmDia = decimal.Parse(salarioSetorComboBox.Text) * valorCargaHorariaTrabalho;
                    break;
            }

            var setSetor = bdSetor.SetDadosSetor(Int32.Parse(empresaPertencenteSetorComboBox.SelectedValue.ToString()), Int32.Parse(salarioSetorComboBox.SelectedValue.ToString()), nomeSetorTextBox.Text, nivelHirarquicoComboBox.Text, funcaoSetorTextBox.Text, periodoTrabalhoComboBox.Text, escalaTrabalhoComboBox.Text, cargaHorariaComboBox.Text,Math.Round( totalSalarioGanhoUmaHora), Math.Round(totalSalarioGanhoUmDia));

            if(setSetor == true)
            {
                empresaPertencenteSetorComboBox.SelectedIndex = 0;
                nomeSetorTextBox.Clear();
                salarioSetorComboBox.SelectedIndex = 0;
                nivelHirarquicoComboBox.SelectedIndex = 0;
                periodoTrabalhoComboBox.SelectedIndex = 0;
                cargaHorariaComboBox.SelectedIndex = 0;
                escalaTrabalhoComboBox.SelectedIndex = 0;
                funcaoSetorTextBox.Clear();
                MessageBox.Show("Dados salvos com Sucesso");
            }
        }
    }
}
