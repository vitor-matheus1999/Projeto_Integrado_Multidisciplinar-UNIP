using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    public partial class FormCadastrarSalario : Form
    {
        ClsBancoDadosSalario bdSalario = new ClsBancoDadosSalario();
        ClsBancoDadosEmpresa bdEmpresa= new ClsBancoDadosEmpresa();
        Salario salario = new Salario();

        public FormCadastrarSalario()
        {
            InitializeComponent();
            bdEmpresa.GetEmpresasComboBox(empresaDistribuidoraSalaraioComboBox);
            salarioBrutoTextBox.Text = "0";
            descontoFGTSComboBox.SelectedIndex = 0;
            descontoValeAlimentacaoComboBox.SelectedIndex = 0;
            descontoValeTransporteComboBox.SelectedIndex = 0;
            empresaDistribuidoraSalaraioComboBox.SelectedIndex = 0;
            descontoINSSTextBox.Text = "0";
            salarioEstagiarioCheckBox.Checked = false;
        }
        private void salarioEstagiarioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(salarioEstagiarioCheckBox.Checked == true)
            {
                descontoINSSTextBox.Text = "0";
                descontoFGTSComboBox.Text = "NÃO";
            }
            else
            {
                descontoFGTSComboBox.Text = "SIM";
            }         
   
        }
        private void salarioBrutoTextBox_TextChanged(object sender, EventArgs e)
        {
            double salario = 0;

            if(salarioBrutoTextBox.Text == "")
            {
                salarioBrutoTextBox.Text = "0";
                Convert.ToDouble(salarioBrutoTextBox.Text);
            }
            if (salarioBrutoTextBox.Text.Contains('.'))
            {             
                salario = float.Parse(salarioBrutoTextBox.Text.Replace('.', ','));
            }
            else
            {
                salario = double.Parse(salarioBrutoTextBox.Text);
            }

            if (salario <= 1302.00)
            {
                descontoINSSTextBox.Text = "7,5%";
            }else
            if (salario >= 1302.00 && salario <= 2571.30)
            {
                descontoINSSTextBox.Text = "9%";
            }else
            if (salario >= 2571.30 && salario <= 3856.94)
            {
                descontoINSSTextBox.Text = "12%";
            }else
            if (salario >= 3856.94 && salario <= 7507.49)
            {
                descontoINSSTextBox.Text = "14%";
            }
        }

        private void salvarInfoSalarioButton_Click(object sender, EventArgs e)
        {
            decimal salarioBruto = 0;
            decimal descontoINSS = 0;

            #region Tratamento Campos Salário
            if(salarioBrutoTextBox.Text == null || empresaDistribuidoraSalaraioComboBox.SelectedIndex == 0 || descontoValeAlimentacaoComboBox.SelectedIndex == 0 || descontoValeTransporteComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor preencha os campos em branco");
                return;
            }
            if (descontoINSSTextBox.Text.Contains(","))
            {
                descontoINSSTextBox.Text.Replace(',', '.');
                descontoINSS = decimal.Parse(descontoINSSTextBox.Text.Remove(2));
            }

            for(var i = 0; i < descontoINSSTextBox.Text.Length; i++)
            {
                if(descontoINSSTextBox.Text[i] == '%')
                {
                    descontoINSS = decimal.Parse(descontoINSSTextBox.Text.Remove(i));
                }
            }
      
            if (salarioBrutoTextBox.Text.Contains('.'))
            {
                salarioBruto = decimal.Parse(salarioBrutoTextBox.Text.Replace('.', ','));
            }

           for(var i = 0; i < salarioBrutoTextBox.Text.Length; i++)
            {
                if (salarioBrutoTextBox.Text[i] == ',' && salarioBrutoTextBox.Text.Contains(",00") || salarioBrutoTextBox.Text[i] == '.' && salarioBrutoTextBox.Text.Contains(".00"))
                {
                    salarioBruto = decimal.Parse (salarioBrutoTextBox.Text.Remove(i));
                }
            }
            #endregion

            var descontoValeTransporte = Int32.Parse(descontoValeTransporteComboBox.Text.Remove(1));        
            var descontoValeAlimentacao = Int32.Parse(descontoValeAlimentacaoComboBox.Text.Remove(1));

            decimal valorDescontadoSalarioBrutoValeTransporte = (Math.Round(salarioBruto * descontoValeTransporte)) /100;
            decimal valorDescontadoSalarioBrutoValeAlimentacao = (Math.Round (salarioBruto * descontoValeAlimentacao)) /100;
            decimal valorDescontadoSalarioBrutoINSS = (Math.Round(salarioBruto * descontoINSS)) /100;
            decimal valorDescontadoSalarioBrutoFGTS;
            if (descontoFGTSComboBox.Text.Contains("SIM"))
            {
                valorDescontadoSalarioBrutoFGTS = (Math.Round(salarioBruto * 8))/100;
            }
            else
            {
                valorDescontadoSalarioBrutoFGTS = 0;
            }

            salario.SetSalarioLiquido = salarioBruto - (valorDescontadoSalarioBrutoValeTransporte + valorDescontadoSalarioBrutoValeAlimentacao + valorDescontadoSalarioBrutoINSS + valorDescontadoSalarioBrutoFGTS);

            if(bdSalario.SetDadosSalario(Int32.Parse(empresaDistribuidoraSalaraioComboBox.SelectedValue.ToString()), salarioBruto, salario.GetSalarioLiquido,descontoFGTSComboBox.Text, descontoINSS, descontoValeTransporte, descontoValeAlimentacao) == true)
            {

                salarioBrutoTextBox.Text = "0";
                descontoFGTSComboBox.SelectedIndex = 0;
                descontoValeAlimentacaoComboBox.SelectedIndex = 0;
                descontoValeTransporteComboBox.SelectedIndex = 0;
                empresaDistribuidoraSalaraioComboBox.SelectedIndex = 0;
                descontoINSSTextBox.Text = "0";
                salarioEstagiarioCheckBox.Checked = false;
                MessageBox.Show("Dados Salvos com Sucesso.");
            }

            
        }

    }
}
