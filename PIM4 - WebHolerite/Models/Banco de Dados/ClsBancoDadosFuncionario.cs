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
                sqlCmd.CommandText = "SELECT id_Funcionario,id_Empresa, id_Setor,nome_Funcionario,data_nascimento,data_admissao,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras FROM TBfuncionario";
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

                    listaFuncionarios.Add(new Funcionario(idFuncionario: funcionario.GetIdFuncionario, idEmpresa: funcionario.GetIdEmpresa, idSetor: funcionario.GetIdSetor, nomeFuncionario: funcionario.GetNomeFuncionario, dataNascimento: funcionario.GetDataNascimento, dataAdmissao: funcionario.GetDataAdmissao, generoFuncionario: funcionario.GetGeneroFuncionario, cpfFuncionario: funcionario.GetCpfFuncionario));
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
        public bool SetDadosFuncionario(int idEmpresa, int idSetor, string nomeFuncionario, string dataNascimento, string dataAdmissao, string sexo, string cpfFuncionario)
        {           
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBfuncionario (id_Empresa,id_Setor,data_nascimento,data_admissao,nome_Funcionario,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras ) VALUES(@idEmpresa,@idSetor,@dataNascimento,@dataAdmissao,@nomeFuncionario, @sexo,@cpfFuncionario,0,0)";
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
        public bool GetLoginSenha(string login, string senha)
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
        public void GetEmpresasComboBox(ComboBox comboBoxEmpresa)
        {       
            try
            {
                sqlCmd.CommandText = "SELECT id_Empresa, nome_Empresarial_Fantasia FROM TBempresa";
                sqlCmd.Connection = conn.conectar();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCmd;
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);

                DataRow itemLinha = tabela.NewRow();
                itemLinha[1] = "Selecione a empresa";
                tabela.Rows.InsertAt(itemLinha, 0);

                comboBoxEmpresa.DataSource = tabela;
                comboBoxEmpresa.DisplayMember = "nome_Empresarial_Fantasia";
                comboBoxEmpresa.ValueMember = "id_Empresa";
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.desconectar();
            }
        }
        public void GetSetoresComboBox(ComboBox comboBoxSetor, int idEmpresa)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Setor, nome_Setor FROM TBsetor WHERE id_Empresa = @idEmpresa";
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Connection = conn.conectar();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCmd;
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);

                DataRow itemLinha = tabela.NewRow();
                itemLinha[1] = "Selecione o Setor";
                tabela.Rows.InsertAt(itemLinha, 0);

                comboBoxSetor.DataSource = tabela;
                comboBoxSetor.DisplayMember = "nome_Setor";
                comboBoxSetor.ValueMember = "id_Setor";
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
        public void GetHierarquiaComboBox(ComboBox comboBoxSetor, string nomeSetor)
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Setor, hierarquia FROM TBsetor WHERE nome_Setor = @nomeSetor";
                sqlCmd.Parameters.AddWithValue("@nomeSetor",nomeSetor);
                sqlCmd.Connection = conn.conectar();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCmd;
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);

                DataRow itemLinha = tabela.NewRow();
                itemLinha[1] = "Selecione o Nível Hierarquico";
                tabela.Rows.InsertAt(itemLinha, 0);

                comboBoxSetor.DataSource = tabela;
                comboBoxSetor.DisplayMember = "hierarquia";
                comboBoxSetor.ValueMember = "id_Setor";
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
        public void GetFuncionariosSetorHierarquiaTextBox(TextBox setorFuncionario, TextBox nivelHierarquico, int idSetor)
        {
            try
            {
                sqlCmd.CommandText = "SELECT nome_Setor, hierarquia FROM TBsetor WHERE id_Setor = @idSetor";
                sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
                sqlCmd.Connection = conn.conectar();
                using(SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        setorFuncionario.Text = dataReader.GetString(dataReader.GetOrdinal("nome_Setor"));
                        nivelHierarquico.Text = dataReader.GetString(dataReader.GetOrdinal("hierarquia"));
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
        }
    }
}