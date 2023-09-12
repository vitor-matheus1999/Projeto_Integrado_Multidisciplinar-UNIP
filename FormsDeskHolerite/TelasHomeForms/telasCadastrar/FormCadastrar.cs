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
            var formSalario = new FormCadastrarSalario();
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
            ShowChildForm.openChildForm(new FormCadastrarSalario(), homeCadastrarPanel);
        }

        private void cadEmpresaButton_Click(object sender, EventArgs e)
        {
            var formEmpresa = new FormCadastrarEmpresa();
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
            ShowChildForm.openChildForm(new FormCadastrarEmpresa(), homeCadastrarPanel);
        }

        private void cadSetorButton_Click(object sender, EventArgs e)
        {
            var formSetor = new FormCadastrarSetor();
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
            ShowChildForm.openChildForm(new FormCadastrarSetor(), homeCadastrarPanel);
        }

        private void cadFuncButton_Click(object sender, EventArgs e)
        {
            var formFuncionario = new FormCadastrarFuncionario();
            guiaHomePanel.Visible = true;
            novoCadastroButton.Visible = true;
            ShowChildForm.openChildForm(new FormCadastrarFuncionario(), homeCadastrarPanel);
        }

        private void novoCadastroButton_Click(object sender, EventArgs e)
        {
            var formCadFunc = new FormCadastrarFuncionario();         
            ShowChildForm.openChildForm(new  FormCadastrar(), homeCadastrarPanel);
            guiaHomePanel.Visible = false;
            novoCadastroButton.Visible = false;            
        }

        private void homeCadastrarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadSocioAdmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
