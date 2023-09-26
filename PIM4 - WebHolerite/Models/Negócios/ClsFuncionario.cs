using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Funcionario
    {
        private int idFuncionario;
        private string nomeFuncionario;
        private int idEmpresa;
        private int idSetor;
        private string generoFuncionario;
        private DateTime dataNascimento;
        private DateTime dataAdmissao;
        private string cpfFuncionario;
        private double horasNaoTrabalhadas;
        private double horasExtras;
        private string tipoContato;
        private string descricaoContato;
        private string senhaSistemaDesktop;

        public Funcionario() { }

        public Funcionario(int idFuncionario, int idEmpresa, int idSetor, string nomeFuncionario, DateTime dataNascimento, DateTime dataAdmissao, string generoFuncionario, string cpfFuncionario)
        {
            this.idFuncionario = idFuncionario;
            this.idEmpresa = idEmpresa;
            this.idSetor = idSetor;
            this.nomeFuncionario = nomeFuncionario;
            this.dataNascimento = dataNascimento;
            this.dataAdmissao = dataAdmissao;
            this.generoFuncionario = generoFuncionario;
            this.cpfFuncionario = cpfFuncionario;
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
        public int GetIdEmpresa { get { return this.idEmpresa; } }
        public int SetIdEmpresa { set { this.idEmpresa = value; } }
        public DateTime GetDataNascimento { get { return this.dataNascimento; } }
        public DateTime SetDataNascimento { set { this.dataNascimento = value; } }
        public DateTime GetDataAdmissao { get { return this.dataAdmissao; } }
        public DateTime SetDataAdmissao { set { this.dataAdmissao = value; } }
        public string GetGeneroFuncionario { get { return this.generoFuncionario; } }
        public string SetGeneroFuncionario { set { this.generoFuncionario = value; } }
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