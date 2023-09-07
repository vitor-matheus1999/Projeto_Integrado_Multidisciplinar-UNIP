using FormsDeskHolerite.TelasHomeForms;
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
        private void button1_Click(object sender, EventArgs e)
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
    }
}
