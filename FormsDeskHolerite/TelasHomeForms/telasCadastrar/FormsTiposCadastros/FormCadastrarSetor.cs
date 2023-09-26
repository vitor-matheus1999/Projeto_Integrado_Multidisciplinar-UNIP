﻿using PIM4___WebHolerite.Models.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarSetor : Form
    {
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();

        public FormCadastrarSetor()
        {
            InitializeComponent();
        }
        private void FormCadastrarSetor_Load(object sender, EventArgs e)
        {
            bdSetor.GetEmpresasComboBox(empresaPertencenteSetorComboBox);
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
            bdSetor.GetSalariosComboBox(salarioSetorComboBox, Convert.ToInt32(empresaPertencenteSetorComboBox.SelectedValue));
            salarioSetorComboBox.Text = "Selecione o Salário";
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
        private void escalaTrabalhoHorasCheckBox_Click(object sender, EventArgs e)
        {
            escalaTrabalhoDiasCheckBox.Checked = false;
            escalaTrabalhoComboBox.Enabled = true;
            #region Tabela Escala por Horas
            DataTable tabelaEscala = new DataTable();
            DataRow itemLinhaEscala = tabelaEscala.NewRow();
            tabelaEscala.Columns.Add("Escala em Horas");
            tabelaEscala.Rows.Add("Escolha a Escala em Horas");
            tabelaEscala.Rows.Add("6:00");
            tabelaEscala.Rows.Add("8:00");
            tabelaEscala.Rows.Add("12:00");
            escalaTrabalhoComboBox.DataSource = tabelaEscala;
            escalaTrabalhoComboBox.DisplayMember = "Escala em Horas";
            #endregion

            if (escalaTrabalhoDiasCheckBox.Checked == false && escalaTrabalhoHorasCheckBox.Checked == false)
            {
                escalaTrabalhoComboBox.Enabled = false;
            }

        }
        private void escalaTrabalhoDiasCheckBox_Click(object sender, EventArgs e)
        {
            escalaTrabalhoHorasCheckBox.Checked = false;
            escalaTrabalhoComboBox.Enabled = true;
            #region Tabela Escala por Dias
            DataTable tabelaEscala = new DataTable();
            DataRow itemLinhaEscala = tabelaEscala.NewRow();
            tabelaEscala.Columns.Add("Escala em Dias");
            tabelaEscala.Rows.Add("Escolha a Escala em Dias");
            tabelaEscala.Rows.Add("5/2");
            tabelaEscala.Rows.Add("6/1");
            tabelaEscala.Rows.Add("7/1");
            escalaTrabalhoComboBox.DataSource = tabelaEscala;
            escalaTrabalhoComboBox.DisplayMember = "Escala em Dias";
            #endregion
            if(escalaTrabalhoDiasCheckBox.Checked == false && escalaTrabalhoHorasCheckBox.Checked == false)
            {
                escalaTrabalhoComboBox.Enabled = false;
            }
        }
        private void salvarInfoSetorButton_Click(object sender, EventArgs e)
        {

            bdSetor.SetDadosSetor(Int32.Parse(empresaPertencenteSetorComboBox.SelectedValue.ToString()), Int32.Parse(salarioSetorComboBox.SelectedValue.ToString()), nomeSetorTextBox.Text, nivelHirarquicoComboBox.Text, funcaoSetorTextBox.Text, periodoTrabalhoComboBox.Text, escalaTrabalhoComboBox.Text, cargaHorariaComboBox.Text);
            MessageBox.Show("Dados salvos com Sucesso");
        }
    }
}
