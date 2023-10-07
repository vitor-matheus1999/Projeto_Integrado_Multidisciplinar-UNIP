using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PIM4___WebHolerite.Models.Negócios;
using System.Windows.Forms;
using System.Data;
using System.Net.Http.Headers;
using System.Web.WebPages;
using System.Data.Common;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsBancoDadosFuncionario {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();
        Funcionario funcionario = new Funcionario();
        List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public List<Funcionario> GetInformacaoFuncionario()
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Funcionario,id_Empresa, id_Setor,nome_Funcionario,data_nascimento,data_admissao,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras,holerite_Finalizado FROM TBfuncionario";
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                    funcionario.SetIdSetor = dataReader.GetInt32(dataReader.GetOrdinal("id_Setor"));
                    funcionario.SetNomeFuncionario = dataReader.GetString(dataReader.GetOrdinal("nome_Funcionario"));
                    funcionario.SetDataNascimento = dataReader.GetDateTime(dataReader.GetOrdinal("data_nascimento"));
                    funcionario.SetDataAdmissao = dataReader.GetDateTime(dataReader.GetOrdinal("data_admissao"));
                    funcionario.SetGeneroFuncionario = dataReader.GetString(dataReader.GetOrdinal("sexo"));
                    funcionario.SetCpfFuncionario = dataReader.GetString(dataReader.GetOrdinal("cpf_Funcionario"));
                    funcionario.SetHorasNaoTrabalhadas = dataReader.GetDouble(dataReader.GetOrdinal("horas_Nao_Trabalhadas"));
                    funcionario.SetHorasExtras = dataReader.GetDouble(dataReader.GetOrdinal("horas_Extras"));
                    funcionario.SetSalarioSeraAcrescentadoDevidoHorasExtras = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Sera_Acrescentado_Devido_Horas_Extras"));
                    funcionario.SetHoleriteFinalizado = dataReader.GetBoolean(dataReader.GetOrdinal("holerite_Finalizado"));

                    listaFuncionarios.Add(new Funcionario(idFuncionario: funcionario.GetIdFuncionario, idEmpresa: funcionario.GetIdEmpresa, idSetor: funcionario.GetIdSetor, nomeFuncionario: funcionario.GetNomeFuncionario, dataNascimento: funcionario.GetDataNascimento, dataAdmissao: funcionario.GetDataAdmissao, generoFuncionario: funcionario.GetGeneroFuncionario, cpfFuncionario: funcionario.GetCpfFuncionario,horasNaoTrabalhadas: funcionario.GetHorasNaoTrabalhadas, horasExtras:funcionario.GetHorasExtras, salarioSeraAcrescentadoDevidoHorasExtras: funcionario.GetSalarioSeraAcrescentadoDevidoHorasExtras, holeriteFinalizado:funcionario.GetHoleriteFinalizado));
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
        public List<Funcionario> GetInformacaoFuncionario(int idEmpresa, int idSetor)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Funcionario, nome_Funcionario, holerite_Finalizado FROM TBfuncionario WHERE id_Empresa = @idEmpresa AND id_Setor = @idSetor";
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetNomeFuncionario = dataReader.GetString(dataReader.GetOrdinal("nome_Funcionario"));
                    funcionario.SetNomeFuncionario = dataReader.GetString(dataReader.GetOrdinal("nome_Funcionario"));
                    funcionario.SetHoleriteFinalizado = dataReader.GetBoolean(dataReader.GetOrdinal("holerite_Finalizado"));

                    listaFuncionarios.Add(new Funcionario(idFuncionario: funcionario.GetIdFuncionario, nomeFuncionario: funcionario.GetNomeFuncionario, holeriteFinalizado:funcionario.GetHoleriteFinalizado));
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return listaFuncionarios;
        }
        public List<Funcionario> GetInformacaoFuncionarioContato()
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Contato_Funcionario,id_Funcionario,tipo_Contato_Funcionario,descricao FROM TBcontatoFuncionario";
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdContatoFuncionario= dataReader.GetInt32(dataReader.GetOrdinal("id_Contato_Funcionario"));
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetTipoContato = dataReader.GetString(dataReader.GetOrdinal("tipo_Contato_Funcionario"));
                    funcionario.SetDescricaoContato = dataReader.GetString(dataReader.GetOrdinal("descricao"));            

                    listaFuncionarios.Add(new Funcionario(idContatoFuncionario: funcionario.GetIdContatoFuncionario, idFuncionario: funcionario.GetIdFuncionario, tipoContatoFuncionario: funcionario.GetTipoContato, descricao: funcionario.GetDescricaoContato));
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
        public Funcionario GetInformacaoFuncionario(int idFuncionario)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Funcionario,id_Empresa, id_Setor,nome_Funcionario,data_nascimento,data_admissao,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras,holerite_Finalizado FROM TBfuncionario WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                    funcionario.SetIdSetor = dataReader.GetInt32(dataReader.GetOrdinal("id_Setor"));
                    funcionario.SetNomeFuncionario = dataReader.GetString(dataReader.GetOrdinal("nome_Funcionario"));
                    funcionario.SetDataNascimento = dataReader.GetDateTime(dataReader.GetOrdinal("data_nascimento"));
                    funcionario.SetDataAdmissao = dataReader.GetDateTime(dataReader.GetOrdinal("data_admissao"));
                    funcionario.SetGeneroFuncionario = dataReader.GetString(dataReader.GetOrdinal("sexo"));
                    funcionario.SetCpfFuncionario = dataReader.GetString(dataReader.GetOrdinal("cpf_Funcionario"));
                    funcionario.SetHorasNaoTrabalhadas = dataReader.GetDouble(dataReader.GetOrdinal("horas_Nao_Trabalhadas"));
                    funcionario.SetHorasExtras = dataReader.GetDouble(dataReader.GetOrdinal("horas_Extras"));
                    funcionario.SetSalarioSeraAcrescentadoDevidoHorasExtras = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Sera_Acrescentado_Devido_Horas_Extras"));
                    funcionario.SetHoleriteFinalizado = dataReader.GetBoolean(dataReader.GetOrdinal("holerite_Finalizado"));

                    return new Funcionario(idFuncionario: funcionario.GetIdFuncionario, idEmpresa: funcionario.GetIdEmpresa, idSetor: funcionario.GetIdSetor, nomeFuncionario: funcionario.GetNomeFuncionario, dataNascimento: funcionario.GetDataNascimento, dataAdmissao: funcionario.GetDataAdmissao, generoFuncionario: funcionario.GetGeneroFuncionario, cpfFuncionario: funcionario.GetCpfFuncionario, horasNaoTrabalhadas: funcionario.GetHorasNaoTrabalhadas, horasExtras:funcionario.GetHorasExtras,salarioSeraAcrescentadoDevidoHorasExtras:funcionario.GetSalarioSeraAcrescentadoDevidoHorasExtras, holeriteFinalizado: funcionario.GetHoleriteFinalizado) ;
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return new Funcionario();
        }
        public Funcionario GetInformacaoFuncionarioEndereco(int idFuncionario)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Endereco_Funcionario, id_Funcionario,rua,numero_moradia, bairro,cep_residencia,cidade FROM TBenderecoFuncionario WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    funcionario.SetIdEnderecoFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Endereco_Funcionario"));
                    funcionario.SetIdFuncionario = dataReader.GetInt32(dataReader.GetOrdinal("id_Funcionario"));
                    funcionario.SetRua = dataReader.GetString(dataReader.GetOrdinal("rua"));
                    funcionario.SetNumeroMoradia = dataReader.GetString(dataReader.GetOrdinal("numero_moradia"));
                    funcionario.SetBairro = dataReader.GetString(dataReader.GetOrdinal("bairro"));
                    funcionario.SetCepResidencia = dataReader.GetString(dataReader.GetOrdinal("cep_residencia"));
                    funcionario.SetCidadeMoradiaFuncionario = dataReader.GetString(dataReader.GetOrdinal("cidade"));

                    return new Funcionario(idEnderecoFuncionario: funcionario.GetIdEnderecoFuncionario, idFuncionario: funcionario.GetIdFuncionario, rua: funcionario.GetRua, numeroRua: funcionario.GetNumeroMoradia, bairro: funcionario.GetBairro, cepResidencia: funcionario.GetCepResidencia, cidadeMoradiaFuncionario: funcionario.GetCidadeMoradiaFuncionario);
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return new Funcionario();
        }
        public int GetIdFuncionario(int idEmpresa, int idSetor, string nomeFuncionario,  string cpfFuncionario)
        {
            var idFuncionario = 0;

            foreach(Funcionario func in listaFuncionarios)
            {
                if(func.GetIdEmpresa == idEmpresa && func.GetIdSetor == idSetor && func.GetNomeFuncionario.Contains(nomeFuncionario) && func.GetCpfFuncionario.Contains(cpfFuncionario))
                {
                    idFuncionario = func.GetIdFuncionario;
                }              
            }
            return idFuncionario;
        }
        public int GetIdFuncionario(string emailFuncionario, List<Funcionario> listaContatoFuncionario)
        {
            var idFuncionario = 0;

            foreach (Funcionario funcionario in listaContatoFuncionario)
            {
                if (funcionario.GetDescricaoContato == emailFuncionario )
                {
                    idFuncionario = funcionario.GetIdFuncionario;
                }
            }
            return idFuncionario;
        }
        public bool GetLoginSenha(string login, string senha)
        {
            List<Funcionario> loginSenha = new List<Funcionario>();

            try
            {
                sqlCmd.Connection = conn.conectar();
                sqlCmd.CommandText = "SELECT contatoFunc.descricao, senhaFuncRh.senha FROM TBsenhaFuncionario AS senhaFuncRh INNER JOIN TBcontatoFuncionario AS contatoFunc ON senhaFuncRh.id_funcionario = contatoFunc.id_Funcionario WHERE tipo_Contato_Funcionario LIKE '%Empresarial'";

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
                sqlCmd.Parameters.Clear();
                dataReader.Close();
            }
            catch (SqlException erro){ MessageBox.Show(erro.Message); }
            finally 
            {
                
                conn.desconectar(); 
            }
            return false;
        }
        public byte GetHoleriteFinalizado(int idFuncionario)
        {
            byte holeriteFinalizado = 0;
            try
            {
                sqlCmd.CommandText = "SELECT holerite_Finalizado FROM TBfuncionario WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Connection = conn.conectar();
                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        holeriteFinalizado = dataReader.GetByte(dataReader.GetOrdinal("holerite_Finalizado"));
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }

            return holeriteFinalizado;
        }
        public void GetFuncionariosAdmEmpresaComboBox(ComboBox comboBoxFuncionariosEmpresa, int idEmpresa)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Funcionario, id_Setor, nome_Funcionario FROM TBfuncionario WHERE id_Empresa = @idEmpresa";
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Connection = conn.conectar();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCmd;
                DataTable tabela = new DataTable();
                tabela.Columns.Add("id_Funcionario", typeof(Int32));
                tabela.Columns.Add("id_Setor", typeof(Int32));
                tabela.Columns.Add("nome_Funcionario", typeof(string));
                dataAdapter.Fill(tabela);

                DataRow itemLinha = tabela.NewRow();
                itemLinha[2] = "Selecione o Funcionário";
                tabela.Rows.InsertAt(itemLinha, 0);

                comboBoxFuncionariosEmpresa.DataSource = tabela;
                comboBoxFuncionariosEmpresa.DisplayMember = "nome_Funcionario";
                comboBoxFuncionariosEmpresa.ValueMember = "id_Funcionario";
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
        }      
        public double GetHorasExtras(int idFuncionario )
        {
            double horasExtras = 0;
            try
            {

                sqlCmd.CommandText = "SELECT horas_Extras FROM TBfuncionario WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Connection = conn.conectar();
                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        horasExtras = dataReader.GetDouble(dataReader.GetOrdinal("horas_Extras"));
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            } 
            return horasExtras;
        }
        public void SetHoleriteFinalizado(int idFuncionario, byte holeriteFinalizado)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE TBfuncionario SET holerite_Finalizado = @holeriteFinalizado WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@holeriteFinalizado", holeriteFinalizado);
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
        }
        public bool SetDadosFuncionario(int idEmpresa, int idSetor, string nomeFuncionario, string dataNascimento, string dataAdmissao, string sexo, string cpfFuncionario)
        {           
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBfuncionario (id_Empresa,id_Setor,data_nascimento,data_admissao,nome_Funcionario,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras, holerite_Finalizado) VALUES(@idEmpresa,@idSetor,@dataNascimento,@dataAdmissao,@nomeFuncionario, @sexo,@cpfFuncionario,0,0,0.00,0)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
                sqlCmd.Parameters.AddWithValue("@nomeFuncionario", nomeFuncionario);
                sqlCmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                sqlCmd.Parameters.AddWithValue("@dataAdmissao", dataAdmissao);
                sqlCmd.Parameters.AddWithValue("@sexo", sexo);
                sqlCmd.Parameters.AddWithValue("@cpfFuncionario", cpfFuncionario);           
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }

            return true;
        }
        public bool SetDadosFuncionario(int idFuncionario, string rua, string numeroMoradia, string bairro, string cep, string cidade)
        {
            try 
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBenderecoFuncionario (id_Funcionario,rua,numero_Moradia,bairro,cep_residencia,cidade) VALUES(@idFuncionario,@rua,@numeroMoradia,@bairro,@cep, @cidade)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@rua", rua);
                sqlCmd.Parameters.AddWithValue("@numeroMoradia", numeroMoradia);
                sqlCmd.Parameters.AddWithValue("@bairro", bairro);
                sqlCmd.Parameters.AddWithValue("@cep", cep);
                sqlCmd.Parameters.AddWithValue("@cidade", cidade);
                sqlCmd.ExecuteNonQuery();

            }
            catch(SqlException erro) 
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally 
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return true;
        }
        public bool SetDadosFuncionario(int idFuncionario, string tipoContato, string descricao)
        {       
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBcontatoFuncionario (id_Funcionario,tipo_Contato_Funcionario,descricao) VALUES(@idFuncionario,@tipoContatoFuncionario, @descricao)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@tipoContatoFuncionario", tipoContato);
                sqlCmd.Parameters.AddWithValue("@descricao", descricao);
   
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return true;
        }
        public bool SetDadosFuncionario(int idEmpresa, int idFuncionario)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBadministradores(id_Empresa, id_Funcionario) VALUES(@idEmpresa ,@idFuncionario)";
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Connection = conn.conectar();
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }

            return true;
        }
        public void SetHorasNaoTrabalhadas(int idFuncionario, float horasNaoTrabalhadas)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE TBfuncionario SET horas_Nao_Trabalhadas = @horasNaoTrabalhadas WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@horasNaoTrabalhadas", horasNaoTrabalhadas);                
                sqlCmd.Connection = conn.conectar();
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
        }
        public void SetHorasExtras(int idFuncionario, float horasExtras)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE TBfuncionario SET horas_Extras = @horasExtras WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@horasExtras", horasExtras);
                sqlCmd.Connection = conn.conectar();
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
        }
        public bool SetSalarioSeraAcrescentadoDevidoHorasExtras(int idFuncionario, double salarioSeraAcrescentadoDevidoHorasExtras)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE TBfuncionario SET salario_Sera_Acrescentado_Devido_Horas_Extras = @salarioSeraAcrescentadoDevidoHorasExtras WHERE id_Funcionario = @idFuncionario";
                sqlCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                sqlCmd.Parameters.AddWithValue("@salarioSeraAcrescentadoDevidoHorasExtras", salarioSeraAcrescentadoDevidoHorasExtras);
                sqlCmd.Connection = conn.conectar();
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                sqlCmd.Parameters.Clear();
                conn.desconectar();
            }
            return true;
        }
    }
}