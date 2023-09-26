using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDeskHolerite;
using FormsDeskHolerite.CommandForms;
using FormsDeskHolerite.TelasHomeForms;
using FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros;
using FormsDeskHolerite.TelasHomeForms.telasCadastrar.FormsTiposCadastros;

namespace FormsDeskHolerite.TelasHomeForms.telasCadastrar
{
    public partial class FormCadastrar : Form
    {
        ClsWorkForm ShowChildForm = new ClsWorkForm();
        FormsHomeDeskHolerite homeDeskHolerite = new FormsHomeDeskHolerite();
        FormCadastrarFuncionario cadFunc = new FormCadastrarFuncionario() ;

        public FormCadastrar()
        {
            InitializeComponent();

        }

        private void cadSalarioButton_Click(object sender, EventArgs e)
        {
            ShowChildForm.openChildForm(new FormCadastrarSalario(), homeCadastrarPanel);
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
        }

        private void cadEmpresaButton_Click(object sender, EventArgs e)
        {
            ShowChildForm.openChildForm(new FormCadastrarEmpresa(), homeCadastrarPanel);
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
        }

        private void cadSetorButton_Click(object sender, EventArgs e)
        {

            ShowChildForm.openChildForm(new FormCadastrarSetor(), homeCadastrarPanel);
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
        }

        private void cadFuncButton_Click(object sender, EventArgs e)
        {
            ShowChildForm.openChildForm(new FormCadastrarFuncionario(), homeCadastrarPanel);
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
        }

        private void novoCadastroButton_Click(object sender, EventArgs e)
        {       
            ShowChildForm.openChildForm(new  FormCadastrar(), homeCadastrarPanel);
            guiaHomePanel.Visible = false;
            novoCadastroButton.Visible = false;            
        }
        private void cadSocioAdmButton_Click(object sender, EventArgs e)
        {
            ShowChildForm.openChildForm(new FormCadastrarSocioAdministrador(), homeCadastrarPanel);
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
        }

        private void homeCadastrarPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
