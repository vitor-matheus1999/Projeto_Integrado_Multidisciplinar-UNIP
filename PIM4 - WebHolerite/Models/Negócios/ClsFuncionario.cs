using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Funcionario
    {
        private int idFuncionario;
        private string nomeFuncionario;
        private int idSetor;
        private string sexo;
        private string cpfFuncionario;
        private double horasNaoTrabalhadas;
        private double horasExtras;
        private string tipoContato;
        private string descricaoContato;
        private string senhaSistemaDesktop;

        public Funcionario() { }

        public Funcionario(int idFuncionario, int idSetor, string nomeFuncionario, string sexo, string cpfFuncionario, double horasNaoTrabalhadas, double horasExtras)
        {
            this.idFuncionario = idFuncionario;
            this.idSetor = idSetor;
            this.nomeFuncionario = nomeFuncionario;
            this.sexo = sexo;
            this.cpfFuncionario = cpfFuncionario;
            this.horasNaoTrabalhadas = horasNaoTrabalhadas;
            this.horasExtras = horasExtras;
        }

        public Funcionario(string emailEmpresarial, string senhaSistemaDesktop)
        {
            this.descricaoContato = emailEmpresarial;
            this.senhaSistemaDesktop = senhaSistemaDesktop;
        }

        public int GetIdFuncionario { get { return this.idFuncionario; } }
        public int SetIdFuncionario { set { this.idFuncionario = value; } }
        public string GetNomeFuncionario { get { return this.nomeFuncionario; } }
        public string SetNomeFuncionario { set { this.nomeFuncionario = value; } }
        public int GetIdSetor { get { return this.idSetor; } }
        public int SetIdSetor { set { this.idSetor = value; } }
        public string GetSexo { get { return this.sexo; } }
        public string SetSexo { set { this.sexo = value; } }
        public string GetCpfFuncionario { get { return this.cpfFuncionario; } }
        public string SetCpfFuncionario { set { this.cpfFuncionario = value; } }
        public double GetHorasNaoTrabalhadas { get { return this.horasNaoTrabalhadas; } }
        public double SetHorasNaoTrabalhadas { set { this.horasNaoTrabalhadas = value; } }
        public double GetHorasExtras { get { return this.horasExtras; } }
        public double SetHorasExtras { set { this.horasExtras = value; } }
        public string GetTipoContato { get { return this.tipoContato; } }
        public string SetTipoContato { set { this.tipoContato = value; } }
        public string GetDescricaoContato { get { return this.descricaoContato; } }
        public string SetDescricaoContato { set { this.descricaoContato = value; } }
        public string GetSenhaSistemaDesktop { get { return this.senhaSistemaDesktop; } }
        public string SetSenhaSistemaDesktop { set { this.senhaSistemaDesktop = value; } }
    }
}