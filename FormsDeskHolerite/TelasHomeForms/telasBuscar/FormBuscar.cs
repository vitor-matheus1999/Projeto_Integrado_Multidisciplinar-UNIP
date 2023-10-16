using FormsDeskHolerite.CommandForms;
using FormsDeskHolerite.TelasHomeForms.telasHolerite;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasBuscar
{
    public partial class FormBuscar : Form
    {
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsWorkForm showChildForm = new ClsWorkForm();

        public FormBuscar()
        {
            InitializeComponent();
            listaBuscaComboBox.SelectedIndex = 0;
        }

        private void listaBuscaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listaBuscaComboBox.SelectedIndex)
            {
                case 1:
                    listaEmpresasComboBox.Visible = true;
                    bdEmpresa.GetEmpresasComboBox(listaEmpresasComboBox);
                    listaSetoresComboBox.Visible = true;
                    bdSetor.GetSetoresComboBox(listaSetoresComboBox,((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<Int32>("id_Empresa"));
                    break;
                case 2:
                    listaEmpresasComboBox.Visible = true;
                    bdEmpresa.GetEmpresasComboBox(listaEmpresasComboBox);
                    break;
                case 3:
                    listaEmpresasComboBox.Visible = true;
                    bdEmpresa.GetEmpresasComboBox(listaEmpresasComboBox);
                    break;
                case 4:
                    listaEmpresasComboBox.Visible = true;
                    bdEmpresa.GetEmpresasComboBox(listaEmpresasComboBox);
                    listaSetoresComboBox.Visible = true;
                    bdSetor.GetSetoresComboBox(listaSetoresComboBox, ((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<Int32>("id_Empresa"));
                    break;
                default:
                    break;
            }
        }

        private void criarListaFuncionariosButton_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("Busca ");

            switch (listaBuscaComboBox.SelectedIndex)
            {
                case 1:
                    buscaTabControl.TabPages.Add(tabPage);
                    tabPage.AutoScroll = true;
                    showChildForm.openChildForm(new FormInformacoesBuscaFuncionario(((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<int>("id_Empresa"), ((DataRowView)listaSetoresComboBox.SelectedItem).Row.Field<int>("id_Setor")), tabPage);          
                    break;
                case 2:
                    buscaTabControl.TabPages.Add(tabPage);
                    tabPage.AutoScroll = true;
                    showChildForm.openChildForm(new FormInformacoesBuscaEmpresas(((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<int>("id_Empresa")), tabPage);
                    break;
                case 3:
                    buscaTabControl.TabPages.Add(tabPage);
                    tabPage.AutoScroll = true;
                    showChildForm.openChildForm(new FormInformacoesBuscaSetor(), tabPage);
                    break;
                case 4:
                    buscaTabControl.TabPages.Add(tabPage);
                    tabPage.AutoScroll = true;
                    showChildForm.openChildForm(new FormInformacoesBuscaSalarios(), tabPage);
                    break;
                default:
                    break;
            }
        }
    }
}
