using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace PIM4___WebHolerite.Models.Negócios
{
    public class Socio
    {
        private int idSocio;
        private int idEmpresa;
        private string tipoSocio;
        private string nome;
        private string tipoRegistroReceitaFederal;
        private string descricaoRegistroReceitaFederal;

        public Socio() { }

        public Socio(int idSocio, int idEmpresa, string tipoSocio, string nome, string tipoRegistroReceitaFederal, string descricaoRegistroReceitaFederal)
        {
            this.idSocio = idSocio;
            this.idEmpresa = idEmpresa;
            this.tipoSocio = tipoSocio;
            this.nome = nome;
            this.tipoRegistroReceitaFederal = tipoRegistroReceitaFederal;
            this.descricaoRegistroReceitaFederal = descricaoRegistroReceitaFederal;
        }

        public int GetIdSocio {get{ return this.idSocio; } }
        public int SetIdSocio{ set{ this.idSocio = value; } }
        public int GetIdEmpresa {get{ return this.idEmpresa; } }
        public int SetIdEmpresa{ set{ this.idEmpresa = value; } }
        public string GetTipoSocio {get{ return this.tipoSocio; } }
        public string SetTipoSocio { set{ this.tipoSocio = value; } }
        public string GetNomeSocio { get { return this.nome; } }
        public string SetNomeSocio { set { this.nome=value; } }
        public string GetTipoRegistroReceitaFederal { get { return this.tipoRegistroReceitaFederal; } }
        public string SetTipoRegistroReceitaFederal { set { this.tipoRegistroReceitaFederal=value; } }
        public string GetDescricaoRegistroReceitaFederal { get { return this.descricaoRegistroReceitaFederal; } }
        public string SetDescricaoRegistroReceitaFederal { set { this.descricaoRegistroReceitaFederal=value; } }

    }
}