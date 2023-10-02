using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Setor
    {
        private int idSetor;
        private int idEmpresa;
        private int idSalario;
        private string nomeSetor;
        private string hierarquia;
        private string funcaoSetor;
        private string periodoTrabalho;
        private string escalaTrabalho;
        private TimeSpan cargaHoraria;
        private decimal salarioGanhoHora;
        private decimal salaraioGanhoDia;

        public Setor() { }
        public Setor(int idSetor, int idEmpresa, int idSalario, string nomeSetor, string hierarquia, string funcaoSetor, string periodoTrabalho, string escalaTrabalho, TimeSpan cargaHoraria, decimal salarioGanhoHora, decimal salaraioGanhoDia)
        {
            this.idSetor = idSetor;
            this.idEmpresa = idEmpresa;
            this.idSalario = idSalario;
            this.nomeSetor = nomeSetor;
            this.hierarquia = hierarquia;
            this.funcaoSetor = funcaoSetor;
            this.periodoTrabalho = periodoTrabalho;
            this.escalaTrabalho = escalaTrabalho;
            this.cargaHoraria = cargaHoraria;
            this.salarioGanhoHora = salarioGanhoHora;
            this.salaraioGanhoDia = salaraioGanhoDia;
        }

        public int GetIdSetor { get{ return this.idSetor; } }
        public int SetIdSetor { set{ this.idSetor = value; } }
        public int GetIdEmpresa { get{ return this.idEmpresa; } }
        public int SetIdEmpresa{ set{ this.idEmpresa = value; } }
        public int GetIdSalario { get{ return this.idSalario ; } }
        public int SetIdSalario { set{ this.idSalario = value; } }
        public string GetNomeSetor { get{ return this.nomeSetor; } }
        public string SetNomeSetor { set{ this.nomeSetor = value; } }
        public string GetHierarquia { get { return this.hierarquia ; } }
        public string SetHierarquia { set { this.hierarquia = value; } }
        public string GetFuncaoSetor { get { return this.funcaoSetor ; } }
        public string SetFuncaoSetor { set { this.funcaoSetor = value; } }
        public string GetPeriodoTrabalho { get { return this.periodoTrabalho ; } }
        public string SetPeriodoTrabalho { set { this.periodoTrabalho = value; } }
        public string GetEscalaTrabalho { get { return this.escalaTrabalho ; } }
        public string SetEscalaTrabalho { set { this.escalaTrabalho = value; } }
        public TimeSpan GetCargaHoraria { get { return this.cargaHoraria ; } }
        public TimeSpan SetCargaHoraria { set { this.cargaHoraria = value; } }
        public decimal GetSalarioGanhoHora { get { return this.salarioGanhoHora ; } }
        public decimal SetSalarioGanhoHora { set { this.salarioGanhoHora = value; } }
        public decimal GetSalarioGanhoDia { get { return this.salaraioGanhoDia; } }
        public decimal SetSalarioGanhoDia { set { this.salaraioGanhoDia = value; } }
    }
}