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
        private int idEmpresa;
        private int idSetor;
        private int idContatoFuncionario;
        private int idEnderecoFuncionario;
        private string nomeFuncionario;
        private string generoFuncionario;
        private DateTime dataNascimento;
        private DateTime dataAdmissao;
        private string cpfFuncionario;
        private double horasNaoTrabalhadas;
        private double horasExtras;
        private string tipoContato;
        private string descricaoContato;
        private string senhaSistemaDesktop;
        private string rua;
        private string numeroMoradia;
        private string bairro;
        private string cepResidencia;
        private string cidadeMoradia;
        private decimal salarioSeraAcrescentadoDevidoHorasExtras;
        private bool holeriteFinalizado;
        private bool funcionarioArquivado;

        public Funcionario() { }
        public Funcionario(int idFuncionario, int idEmpresa, int idSetor, string nomeFuncionario, DateTime dataNascimento, DateTime dataAdmissao, string generoFuncionario, string cpfFuncionario, double horasNaoTrabalhadas, double horasExtras, decimal salarioSeraAcrescentadoDevidoHorasExtras, bool holeriteFinalizado, bool funcionarioArquivado)
        {
            this.idFuncionario = idFuncionario;
            this.idEmpresa = idEmpresa;
            this.idSetor = idSetor;
            this.nomeFuncionario = nomeFuncionario;
            this.dataNascimento = dataNascimento;
            this.dataAdmissao = dataAdmissao;
            this.generoFuncionario = generoFuncionario;
            this.cpfFuncionario = cpfFuncionario;
            this.horasNaoTrabalhadas = horasNaoTrabalhadas;
            this.horasExtras = horasExtras;
            this.salarioSeraAcrescentadoDevidoHorasExtras = salarioSeraAcrescentadoDevidoHorasExtras;
            this.holeriteFinalizado = holeriteFinalizado;
            this.funcionarioArquivado = funcionarioArquivado;
        }
        public Funcionario(string emailEmpresarial, string senhaSistemaDesktop)
        {
            this.descricaoContato = emailEmpresarial;
            this.senhaSistemaDesktop = senhaSistemaDesktop;
        }
        public Funcionario(int idFuncionario, string nomeFuncionario, bool holeriteFinalizado, bool funcionarioArquivado)
        {
            this.idFuncionario = idFuncionario;
            this.nomeFuncionario = nomeFuncionario;
            this.holeriteFinalizado = holeriteFinalizado;
            this.funcionarioArquivado = funcionarioArquivado;
        }
        public Funcionario(int idEnderecoFuncionario, int idFuncionario, string rua, string numeroRua, string bairro, string cepResidencia, string cidadeMoradiaFuncionario)
        {
            this.idEnderecoFuncionario = idEnderecoFuncionario;
            this.idFuncionario = idFuncionario;
            this.rua = rua;
            this.numeroMoradia = numeroRua;
            this.bairro = bairro;
            this.cepResidencia = cepResidencia;
            this.cidadeMoradia = cidadeMoradiaFuncionario;
        }

        public Funcionario(int idContatoFuncionario, int idFuncionario, string tipoContatoFuncionario, string descricao)
        {
            this.idContatoFuncionario = idContatoFuncionario;
            this.idFuncionario = idFuncionario;
            this.tipoContato = tipoContatoFuncionario;
            this.descricaoContato = descricao;
        }

        public int GetIdFuncionario { get { return this.idFuncionario; } }
        public int SetIdFuncionario { set { this.idFuncionario = value; } }
        public int GetIdSetor { get { return this.idSetor; } }
        public int SetIdSetor { set { this.idSetor = value; } }
        public int GetIdEmpresa { get { return this.idEmpresa; } }
        public int SetIdEmpresa { set { this.idEmpresa = value; } }
        public int GetIdContatoFuncionario { get { return this.idContatoFuncionario; } }
        public int SetIdContatoFuncionario { set { this.idContatoFuncionario = value; } }
        public string GetNomeFuncionario { get { return this.nomeFuncionario; } }
        public string SetNomeFuncionario { set { this.nomeFuncionario = value; } }
        public int GetIdEnderecoFuncionario { get { return this.idEnderecoFuncionario; } }
        public int SetIdEnderecoFuncionario { set { this.idEnderecoFuncionario = value; } }
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
        public string GetRua { get { return this.rua; } }
        public string SetRua { set { this.rua = value; } }
        public string GetNumeroMoradia { get { return this.numeroMoradia; } }
        public string SetNumeroMoradia { set { this.numeroMoradia = value; } }
        public string GetBairro { get { return this.bairro; } }
        public string SetBairro { set { this.bairro = value; } }
        public string GetCepResidencia { get { return this.cepResidencia; } }
        public string SetCepResidencia { set { this.cepResidencia = value; } }
        public string GetCidadeMoradiaFuncionario { get { return this.cidadeMoradia; } }
        public string SetCidadeMoradiaFuncionario { set { this.cidadeMoradia = value; } }
        public decimal GetSalarioSeraAcrescentadoDevidoHorasExtras { get { return this.salarioSeraAcrescentadoDevidoHorasExtras; } }
        public decimal SetSalarioSeraAcrescentadoDevidoHorasExtras { set { this.salarioSeraAcrescentadoDevidoHorasExtras = value; } }
        public bool GetHoleriteFinalizado { get { return this.holeriteFinalizado; } }
        public bool SetHoleriteFinalizado { set { this.holeriteFinalizado = value; } }
        public bool GetFuncionarioArquivado { get {return this.funcionarioArquivado; } }
        public bool SetFuncionarioArquivado { set { this.funcionarioArquivado = value; } }
    }
}
