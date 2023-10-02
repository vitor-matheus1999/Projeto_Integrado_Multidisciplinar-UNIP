using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PIM4___WebHolerite.Models.Negócios;
using System.Windows.Forms;
using System.Data;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsBancoDadosSocio
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();
        Socio socio = new Socio();
        List<Socio> listaSocios = new List<Socio>();

        public List<Socio> GetDadosSocio()
        {
            try
            {
                sqlCmd.CommandText = "SELECT * FROM TBsocios";
                sqlCmd.Connection = conn.conectar();
                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        socio.SetIdSocio = dataReader.GetInt32(dataReader.GetOrdinal("id_Socios"));
                        socio.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                        socio.SetTipoSocio = dataReader.GetString(dataReader.GetOrdinal("tipo_socio"));
                        socio.SetNomeSocio = dataReader.GetString(dataReader.GetOrdinal("nome"));
                        socio.SetTipoRegistroReceitaFederal = dataReader.GetString(dataReader.GetOrdinal("tipo_Registo_Receita_Federal"));
                        socio.SetDescricaoRegistroReceitaFederal = dataReader.GetString(dataReader.GetOrdinal("descricao_Registro_Receita_Federal"));

                        listaSocios.Add(new Socio( idSocio: socio.GetIdSocio,  idEmpresa: socio.GetIdEmpresa,  tipoSocio: socio.GetTipoSocio,  nome: socio.GetNomeSocio,  tipoRegistroReceitaFederal: socio.GetTipoRegistroReceitaFederal,  descricaoRegistroReceitaFederal: socio.GetDescricaoRegistroReceitaFederal));
                    }
                }
            }
            catch(SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conn.desconectar();
            }

            return listaSocios;
        }
        public bool SetDadosSocio( int idEmpresa, string tipoSocios, string nomeSocio, string tipoRegistroReceitaFederal, string descricaoRegistroReceitaFederal)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBsocios(id_empresa,tipo_socio,nome,tipo_Registro_Receita_Federal,descricao_Registro_Receita_Federal) VALUES(@idEmpresa, @tipoSocio, @nomeSocio, @tipoRegistroReceitaFederal, @descricaoRegistroReceitaFederal)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@tipoSocio", tipoSocios);
                sqlCmd.Parameters.AddWithValue("@nomeSocio", nomeSocio);
                sqlCmd.Parameters.AddWithValue("@tipoRegistroReceitaFederal", tipoRegistroReceitaFederal);
                sqlCmd.Parameters.AddWithValue("@descricaoRegistroReceitaFederal", descricaoRegistroReceitaFederal);
                sqlCmd.ExecuteNonQuery();

            }
            catch(SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                conn.desconectar();
                sqlCmd.Parameters.Clear();
            }
            return true;
        }
    }
}