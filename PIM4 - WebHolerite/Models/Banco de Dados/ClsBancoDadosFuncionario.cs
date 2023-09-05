using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PIM4___WebHolerite.Models.Negócios;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class BancoDadosFuncionario
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();

        public List<Funcionario> GetInformacaoFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            List<Funcionario> listaIdSetorFuncionario = new List<Funcionario>();

            sqlCmd.CommandText = "SELECT id_Funcionario, id_Setor,nome_Funcionario,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras FROM TBfuncionario";
            sqlCmd.Connection = conn.conectar();
            try
            {
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetIdSetor = dataReader.GetInt32(dataReader.GetOrdinal("id_Setor"));
                    funcionario.SetNomeFuncionario = dataReader.GetString(dataReader.GetOrdinal("nome_Funcionario"));
                    funcionario.SetSexo = dataReader.GetString(dataReader.GetOrdinal("sexo"));
                    funcionario.SetCpfFuncionario = dataReader.GetString(dataReader.GetOrdinal("cpf_Funcionario"));
                    funcionario.SetHorasNaoTrabalhadas = dataReader.GetDouble(dataReader.GetOrdinal("horas_Nao_Trabalhadas"));
                    funcionario.SetHorasExtras = dataReader.GetDouble(dataReader.GetOrdinal("horas_Extras"));

                    listaIdSetorFuncionario.Add(new Funcionario(idFuncionario: funcionario.GetIdFuncionario, idSetor: funcionario.GetIdSetor, nomeFuncionario: funcionario.GetNomeFuncionario, sexo: funcionario.GetSexo, cpfFuncionario: funcionario.GetCpfFuncionario, horasNaoTrabalhadas: funcionario.GetHorasNaoTrabalhadas, horasExtras: funcionario.GetHorasExtras));
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.desconectar();
            }


            return listaIdSetorFuncionario;
        }

        public void CadastrarDadosFuncionario(int idSetor, string nomeFuncionario, string sexo, string cpfFuncionario, double horasNaoTrabalhadas, double horasExtras)
        {
            sqlCmd.CommandText = "INSERT INTO TBfuncionario (id_Setor,nome_Funcionario,sexo,cpf_Funcionario,horas_Nao_Trabalhadas, horas_Extras) VALUES(@idSetor, @nomeFuncionario,@sexo,@cpfFuncionario, @horasNaoTrabalhadas,@horasExtras)";
            sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
            sqlCmd.Parameters.AddWithValue("@nomeFuncionario", nomeFuncionario);
            sqlCmd.Parameters.AddWithValue("@sexo", sexo);
            sqlCmd.Parameters.AddWithValue("@cpfFuncionario", cpfFuncionario);
            sqlCmd.Parameters.AddWithValue("@horasNaoTrabalhadas", horasNaoTrabalhadas);
            sqlCmd.Parameters.AddWithValue("@horasExtras", horasExtras);

            try
            {
                sqlCmd.Connection = conn.conectar();
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conn.desconectar();
            }
        }

    }
}