using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using System.Net.Mail;
using FluentEmail;
using System.Windows.Forms;
using System.Threading.Tasks;
using FluentEmail.Smtp;

namespace PIM4___WebHolerite.Controllers
{
    public class WebHoleriteController : Controller
    {
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        Funcionario funcionario = new Funcionario();
        // GET: WebHolerite
        public ActionResult Index()
        {
            ViewBag.idFuncionario = TempData["idFuncionario"];
            TempData["funcionario"] = funcionario = bdFuncionario.GetInformacaoFuncionario(ViewBag.idFuncionario);
            ViewBag.nomeFuncionario = funcionario.GetNomeFuncionario;
            return View();
        }
        public ActionResult LoginWebHolerite()
        {
            ViewBag.Login = TempData["ConfirmacaoLogin"];
            TempData["ExisteEmail"] = null;
            return View();
        }
        public ActionResult EsqueceuSenha()
        {
            ViewBag.ConfirmacaoEmail = null;
            ViewBag.ConfirmacaoEmail = TempData["ExisteEmail"];
            ViewBag.EmailUsado = TempData["EmailUsado"];
            ViewBag.MensagemEmailValido = "Enviaremos um link para seu email para ALTERAR sua senha.";
            return View();
        }
        public ActionResult EsqueceuSenhaConfirmacao()
        {
            ViewBag.SenhaAtualizada = false;
            ViewBag.SenhaAtualizada = TempData["SenhaAtualizada"];

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Login = TempData["ConfirmacaoLogin"];
            return View();
        }
        [HttpPost]
        public ActionResult VerificacaoLogin()
        {
            if (bdFuncionario.GetLoginSenha(Request["email"], Request["senha"]) == true)
            {
                int idFuncionario = bdFuncionario.GetIdFuncionario(Request["email"], bdFuncionario.GetInformacaoFuncionarioContato());
                TempData["idFuncionario"] = idFuncionario;
                return RedirectToAction("Index");
            }

            TempData["ConfirmacaoLogin"] = false;
            return RedirectToAction("Login");
        }
        [HttpPost]
        public  ActionResult VerificacaoEmail()
        {
            if (bdFuncionario.GetConfirmacaoLogin(Request["email"]) == true)
            {
                TempData["EmailUsado"] = Request["email"];
                EnviarEmail(Request["email"], "Para nosso Funcionario");
                TempData["ExisteEmail"] = true;
            }
            else
            {
                TempData["EmailUsado"] = Request["email"];
                TempData["ExisteEmail"] = false;
            }

            return RedirectToAction("EsqueceuSenha");
        }
       
        [HttpPost]
        public ActionResult RedefinicaoSenha()
        {
            int idContatoFuncionario = 0;

            foreach (Funcionario funcionario in bdFuncionario.GetInformacaoFuncionarioContato())
            {
                if (Request["emailRedefinicaoSenha"] == funcionario.GetDescricaoContato)
                {
                    idContatoFuncionario = funcionario.GetIdContatoFuncionario;
                    break;
                }
            }
            if(bdFuncionario.SetUpdateSenha(Request["senha"], idContatoFuncionario) == true)
            {
                TempData["SenhaAtualizada"] = true;
            }
            return RedirectToAction("EsqueceuSenhaConfirmacao");
        }

        public void EnviarEmail(string emailUsado, string nomeFuncionario)
        {
            try 
            {
                MailMessage email = new MailMessage();
                SmtpClient smtp = new SmtpClient("localhost");
                smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtp.PickupDirectoryLocation = @"C:\Users\Comum\Desktop\faculdade\PIM QUARTO SEMESTRE\PIM4 - WebHolerite\emails";
                smtp.EnableSsl = false;

                email.From = new MailAddress("webholerite@outlook.com", "Web Holerite");
                email.To.Add(new MailAddress(emailUsado, nomeFuncionario));
                email.Subject = "Redefinição de Senha";
                email.IsBodyHtml = true;
                email.Body = "Clique no link para redefinar sua senha: <br><a href='https://localhost:44311/WebHolerite/EsqueceuSenhaConfirmacao?emailUsado= " + emailUsado + "'>Mudar Senha</a>";

                smtp.Send(email);
              
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}