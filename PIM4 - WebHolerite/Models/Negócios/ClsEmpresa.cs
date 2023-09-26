using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Empresa
    {
        private int idEmpresa;
        private string nomeEmpresarialFantasia;
        private string CNAE;
        private string CNPJ;
        private string situacaoCadastral;
        private string naturezaJuridica;
        private DateTime dataAbertura;
        private string atividadesEconomicas;

        public Empresa() { }

        public Empresa(int idEmpresa, string nomeEmpresarialFantasia, string CNAE, string CNPJ, string situacaoCadastral, string naturezaJuridica, DateTime dataAbertura, string atividadesEconomicas)
        {
            this.idEmpresa = idEmpresa;
            this.nomeEmpresarialFantasia = nomeEmpresarialFantasia;
            this.CNAE = CNAE;
            this.CNPJ = CNPJ;
            this.situacaoCadastral = situacaoCadastral;
            this.naturezaJuridica = naturezaJuridica;
            this.dataAbertura = dataAbertura;
            this.atividadesEconomicas = atividadesEconomicas;
        }

        public int GetIdEmpresa { get { return this.idEmpresa; } }
        public int SetIdEmpresa { set { this.idEmpresa = value; } }
        public string GetNomeEmpresarilFantasia { get { return this.nomeEmpresarialFantasia; } }
        public string SetNomeEmpresarilFantasia { set { this.nomeEmpresarialFantasia = value; } }
        public string GetCNAE { get { return this.CNAE; } }
        public string SetCNAE { set { this.CNAE = value; } }
        public string GetCNPJ { get { return this.CNPJ; } }
        public string SetCNPJ { set { this.CNPJ = value; } }
        public string GetSituacaoCadastral { get { return this.situacaoCadastral; } }
        public string SetSituacaoCadastral { set { this.situacaoCadastral = value; } }
        public string GetNaturezaJuridica { get { return this.naturezaJuridica; } }
        public string SetNaturezaJuridica { set { this.naturezaJuridica = value; } }
        public DateTime GetDataAbertura { get { return this.dataAbertura; } }
        public DateTime SetDataAbertura { set { this.dataAbertura = value; } }
        public string GetAtividadesEconomicas { get { return this.atividadesEconomicas; } }
        public string SetAtividadesEconomicas { set { this.atividadesEconomicas = value; } }
    }
}