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
        private double salarioBruto;
        private double salarioLiquido;
        private float descontoFGTS;
        private float descontoINSS;
        private float descontoValeTransporte;
        private float descontoValeAlimentacao;

        public Salario() { }

        public Salario(int idSalario, int idEmpresa, double salarioBruto, double salarioLiquido, float descontoFGTS, float descontoINSS, float descontoValeTransporte, float descontoValeAlimentacao)
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

        public int GetIdSalario { get { return this.idSalario; } }
        public int SetIdSalario { set { this.idSalario = value; } }
        public int GetIdEmpresa{ get { return this.idEmpresa; } }
        public int SetIdEmpresa { set { this.idEmpresa = value; } }
        public double GetSalarioBruto { get { return this.salarioBruto; } }
        public double SetSalarioBruto { set { this.salarioBruto = value; } }
        public double GetSalarioLiquido { get { return this.salarioLiquido; } }
        public double SetSalarioLiquido { set { this.salarioLiquido = value; } }
        public float GetDescontoFGTS { get { return this.descontoFGTS; } }
        public float SetDescontoFGTS { set { this.descontoFGTS = value; } }
        public float GetDescontoINSS { get { return this.descontoINSS; } }
        public float SetDescontoINSS { set { this.descontoINSS = value; } }
        public float GetDescontoValeTransporte{ get { return this.descontoValeTransporte; } }
        public float SetDescontoValeTransporte{ set { this.descontoValeTransporte = value; } }
        public float GetDescontoValeAlimentacao { get { return this.descontoValeAlimentacao; } }
        public float SetDescontoValeAlimentacao { set { this.descontoValeAlimentacao = value; } }


    }
}