using FormsDeskHolerite.TelasHomeForms;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsDeskHolerite
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        
        }
        private void textBoxSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) && textBoxSenha.Text.Contains("Insira sua senha"))
            {
                textBoxLogin.Text = "Insira seu e-mail empresarial";
            }                       
            if (textBoxSenha.Text.Contains("Insira sua senha"))
            {
                textBoxSenha.Text = "";
                this.textBoxSenha.UseSystemPasswordChar = true;
            }
        }
        private void textBoxLogin_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBoxSenha.Text) && textBoxLogin.Text.Contains("Insira seu e-mail empresarial")) 
            {
                textBoxSenha.Text = "Insira sua senha";
                this.textBoxSenha.UseSystemPasswordChar = false;
            }

            if (textBoxLogin.Text.Contains("Insira seu e-mail empresarial"))
            {
                this.textBoxSenha.UseSystemPasswordChar = false;
                textBoxLogin.Text = "";
            }

        }
        private void logarButton_Click(object sender, EventArgs e)
        {
            BancoDadosFuncionario bdFuncionario = new BancoDadosFuncionario();

            if(bdFuncionario.ChecarLoginSenha(textBoxLogin.Text, textBoxSenha.Text) == true)
            {
                var homeDeskHolerite = new FormsHomeDeskHolerite();
                homeDeskHolerite.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Senha incorreta");
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
   
        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }

        }

        private void closeButtonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
