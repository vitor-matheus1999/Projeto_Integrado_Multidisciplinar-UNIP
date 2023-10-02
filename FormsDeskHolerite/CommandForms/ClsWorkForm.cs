using FormsDeskHolerite.TelasHomeForms.telasCadastrar.FormsTiposCadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.CommandForms
{
    public class ClsWorkForm
    {
        public Form currentChildForm;

        public void openChildForm(Form childForm, Panel panel)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //        if (Application.OpenForms.OfType<FormCadastrarSocioAdministrador>().Count() == 1)
        //        {
        //            return;
        //        }
        //        else
        //        {
        //            formSociosAdms.Show();
        //        }
        //
    }
}
