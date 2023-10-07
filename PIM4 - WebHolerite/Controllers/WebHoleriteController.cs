using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;


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
            funcionario = bdFuncionario.GetInformacaoFuncionario(ViewBag.idFuncionario);
            ViewBag.nomeFuncionario = funcionario.GetNomeFuncionario;
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
    }
}