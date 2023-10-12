using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsConexaoSql
    {

        SqlConnection conexaoSql = new SqlConnection();
        public void conexaoSQL()
        {
            conexaoSql.ConnectionString = @"Data Source=DESKTOP-KV08MGN;Initial Catalog =BDfolhaDePagamento;User ID=VITORM;Password=Boal@90929965@.@,;";
        }

        public SqlConnection conectar()
        {
            if (conexaoSql.State == System.Data.ConnectionState.Closed)
            {
                conexaoSQL();
                conexaoSql.Open();
            }
            return conexaoSql;
        }

        public void desconectar()
        {
            if (conexaoSql.State == System.Data.ConnectionState.Open)
            {
                conexaoSql.Close();
            }
        }
    }
}