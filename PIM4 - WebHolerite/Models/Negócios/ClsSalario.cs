using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Salario
    {
        private int idSalario;
        private int idEmpresa;
        private decimal salarioBruto;
        private decimal salarioLiquido;
        private decimal descontoFGTS;
        private decimal descontoINSS;
        private float descontoValeTransporte;
        private float descontoValeAlimentacao;

        public Salario() { }

        public Salario(int idSalario, int idEmpresa, decimal salarioBruto, decimal salarioLiquido, decimal descontoFGTS, decimal descontoINSS, float descontoValeTransporte, float descontoValeAlimentacao)
        {
            this.idSalario = idSalario;
            this.idEmpresa = idEmpresa;
            this.salarioBruto = salarioBruto;
            this.salarioLiquido = salarioLiquido;
            this.descontoFGTS = descontoFGTS;
            this.descontoINSS = descontoINSS;
            this.descontoValeTransporte = descontoValeTransporte;
            this.descontoValeAlimentacao = descontoValeAlimentacao;
        }
        public Salario(decimal salarioBruto, decimal salarioLiquido) 
        {
            this.salarioBruto = salarioBruto;
            this.salarioLiquido = salarioLiquido;
        }


        public int GetIdSalario { get { return this.idSalario; } }
        public int SetIdSalario { set { this.idSalario = value; } }
        public int GetIdEmpresa{ get { return this.idEmpresa; } }
        public int SetIdEmpresa { set { this.idEmpresa = value; } }
        public decimal GetSalarioBruto { get { return this.salarioBruto; } }
        public decimal SetSalarioBruto { set { this.salarioBruto = value; } }
        public decimal GetSalarioLiquido { get { return this.salarioLiquido; } }
        public decimal SetSalarioLiquido { set { this.salarioLiquido = value; } }
        public decimal GetDescontoFGTS { get { return this.descontoFGTS; } }
        public decimal SetDescontoFGTS { set { this.descontoFGTS = value; } }
        public decimal GetDescontoINSS { get { return this.descontoINSS; } }
        public decimal SetDescontoINSS { set { this.descontoINSS = value; } }
        public float GetDescontoValeTransporte{ get { return this.descontoValeTransporte; } }
        public float SetDescontoValeTransporte{ set { this.descontoValeTransporte = value; } }
        public float GetDescontoValeAlimentacao { get { return this.descontoValeAlimentacao; } }
        public float SetDescontoValeAlimentacao { set { this.descontoValeAlimentacao = value; } }


    }
}