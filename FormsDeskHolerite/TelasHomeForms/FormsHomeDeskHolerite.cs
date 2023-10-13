using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using FormsDeskHolerite.TelasHomeForms.telasCadastrar;
using FormsDeskHolerite.TelasHomeForms.telasArquivar;
using FormsDeskHolerite.TelasHomeForms.telasBuscar;
using FormsDeskHolerite.TelasHomeForms.telasHolerite;
using FormsDeskHolerite.TelasHomeForms.telasRelatório;
using FormsDeskHolerite.CommandForms;
using FormsDeskHolerite;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;


namespace FormsDeskHolerite.TelasHomeForms
{
    public partial class FormsHomeDeskHolerite : Form
    {
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        Funcionario funcionario = new Funcionario();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        ClsWorkForm showChildForm = new ClsWorkForm();

        public FormsHomeDeskHolerite()
        {
            InitializeComponent();
        }

        public FormsHomeDeskHolerite(string emailFuncionario)
        {
            InitializeComponent();

            var idFuncionario = bdFuncionario.GetIdFuncionario(emailFuncionario);

            funcionario = bdFuncionario.GetInformacaoFuncionario(idFuncionario);

            nomeFuncionarioLabel.Text = funcionario.GetNomeFuncionario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam );
        private void tituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112,0xf012,  0);
            }

        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.windowPanel.Size = new Size(1070,800);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.windowPanel.Size = new Size(656, 433);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            showChildForm.openChildForm(new FormCadastrar(), windowPanel);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            showChildForm.openChildForm(new FormBuscar(),windowPanel);
        }

        private void relatorioButton_Click(object sender, EventArgs e)
        {
            showChildForm.openChildForm(new FormRelatorio(), windowPanel);
        }

        private void holeriteButton_Click(object sender, EventArgs e)
        {
            showChildForm.openChildForm(new FormHolerite(), windowPanel);
        }

        private void arquivarDadosButton_Click(object sender, EventArgs e)
        {
            showChildForm.openChildForm(new FormArquivar(), windowPanel);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair ?", "AVIS0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                new Login().Show();

            }
        }

        private void windowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
