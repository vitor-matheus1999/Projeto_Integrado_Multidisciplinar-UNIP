using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PIM4___WebHolerite.Models.Negócios;
using System.Windows.Forms;


namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class BancoDadosFuncionario
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();

        Funcionario funcionario = new Funcionario();

        public List<Funcionario> GetInformacaoFuncionario()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

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

                    listaFuncionarios.Add(new Funcionario(idFuncionario: funcionario.GetIdFuncionario, idSetor: funcionario.GetIdSetor, nomeFuncionario: funcionario.GetNomeFuncionario, sexo: funcionario.GetSexo, cpfFuncionario: funcionario.GetCpfFuncionario, horasNaoTrabalhadas: funcionario.GetHorasNaoTrabalhadas, horasExtras: funcionario.GetHorasExtras));
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


            return listaFuncionarios;
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

        public bool ChecarLoginSenha(string login, string senha)
        {
            List<Funcionario> loginSenha = new List<Funcionario>();

            try
            {
                sqlCmd.Connection = conn.conectar();
                sqlCmd.CommandText = "SELECT contatoFunc.descricao, senhaFuncRh.senha  FROM TBsenhaFuncionario AS senhaFuncRh INNER JOIN TBcontatoFuncionario AS contatoFunc ON senhaFuncRh.id_funcionario = contatoFunc.id_Funcionario WHERE tipo_Contato_Funcionario LIKE '%Empresarial'";

                sqlCmd.Parameters.AddWithValue("@login",login);
                sqlCmd.Parameters.AddWithValue("@senha",senha);
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
               

                while (dataReader.Read())
                {

                    funcionario.SetDescricaoContato = dataReader.GetString(dataReader.GetOrdinal("descricao"));
                    funcionario.SetSenhaSistemaDesktop = dataReader.GetString(dataReader.GetOrdinal("senha"));

                    loginSenha.Add(new Funcionario(emailEmpresarial: funcionario.GetDescricaoContato, senhaSistemaDesktop: funcionario.GetSenhaSistemaDesktop));
                }

                foreach( Funcionario funcionarioLoginSenha in loginSenha)
                {
                    if (login.Contains(funcionarioLoginSenha.GetDescricaoContato) && senha.Contains(funcionarioLoginSenha.GetSenhaSistemaDesktop))
                    {
                        return true;
                    }
                }

                dataReader.Close();
            }
            catch (SqlException erro){ MessageBox.Show(erro.Message); }
            finally 
            {
                
                conn.desconectar(); 
            }
            return false;
        }
    }
}