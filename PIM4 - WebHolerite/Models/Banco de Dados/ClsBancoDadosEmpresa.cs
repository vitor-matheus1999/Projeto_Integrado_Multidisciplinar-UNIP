using PIM4___WebHolerite.Models.Negócios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsBancoDadosEmpresa
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();
        Empresa empresa = new Empresa();
        List<Empresa> listaEmpresas = new List<Empresa>();

        string nomeEmpresa;

        public List<Empresa> GetInformacaoEmpresa()
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Empresa,nome_Empresarial_Fantasia, CNAE,CNPJ,situacao_Cadastral,natureza_Juridica,data_Abertura,atividades_Economicas FROM TBempresa";
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    empresa.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                    empresa.SetNomeEmpresarilFantasia = dataReader.GetString(dataReader.GetOrdinal("nome_Empresarial_Fantasia"));
                    empresa.SetCNAE = dataReader.GetString(dataReader.GetOrdinal("CNAE"));
                    empresa.SetCNPJ = dataReader.GetString(dataReader.GetOrdinal("CNPJ"));
                    empresa.SetSituacaoCadastral = dataReader.GetString(dataReader.GetOrdinal("situacao_Cadastral"));
                    empresa.SetNaturezaJuridica = dataReader.GetString(dataReader.GetOrdinal("natureza_Juridica"));
                    empresa.SetDataAbertura = dataReader.GetDateTime(dataReader.GetOrdinal("data_Abertura"));
                    empresa.SetAtividadesEconomicas = dataReader.GetString(dataReader.GetOrdinal("atividades_Economicas"));

                    listaEmpresas.Add(new Empresa(idEmpresa: empresa.GetIdEmpresa, nomeEmpresarialFantasia: empresa.GetNomeEmpresarilFantasia, CNAE: empresa.GetCNAE, CNPJ: empresa.GetCNPJ, situacaoCadastral: empresa.GetSituacaoCadastral, naturezaJuridica: empresa.GetNaturezaJuridica, dataAbertura: empresa.GetDataAbertura, atividadesEconomicas: empresa.GetAtividadesEconomicas));
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

            return listaEmpresas;
        }
        public int GetIdEmpresa( string CNAE, string CNPJ)
        {
            var idEmpresa = 0;

            foreach (Empresa emp in listaEmpresas)
            {
                if (emp.GetCNAE == CNAE && emp.GetCNPJ == CNPJ)
                {
                    idEmpresa = emp.GetIdEmpresa;
                }
            }
            return idEmpresa;
        }
        public string GetNomeEmpresa(int idEmpresa) 
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT nome_Empresarial_Fantasia FROM TBempresa WHERE id_Empresa = @idEmpresa";
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Connection = conn.conectar();

                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        nomeEmpresa = dataReader.GetString(dataReader.GetOrdinal("nome_Empresarial_Fantasia"));
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
            return nomeEmpresa;
        }
        public bool SetDadosEmpresa(string nomeEmpresarialFantasia, string CNAE, string CNPJ, string situacaoCadastral, string naturezaJuridica, string dataAbertura, string atividadesEconomicas)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBempresa (nome_Empresarial_Fantasia, CNAE,CNPJ,situacao_Cadastral,natureza_Juridica,data_Abertura,atividades_Economicas ) VALUES(@nomeEmpresarialFantasia,@CNAE,@CNPJ,@situacaoCadastral,@naturezaJuridica, @dataAbertura,@atividadesEconomicas)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@nomeEmpresarialFantasia", nomeEmpresarialFantasia);
                sqlCmd.Parameters.AddWithValue("@CNAE", CNAE);
                sqlCmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                sqlCmd.Parameters.AddWithValue("@situacaoCadastral", situacaoCadastral);
                sqlCmd.Parameters.AddWithValue("@naturezaJuridica", naturezaJuridica);
                sqlCmd.Parameters.AddWithValue("@dataAbertura", dataAbertura);
                sqlCmd.Parameters.AddWithValue("@atividadesEconomicas", atividadesEconomicas);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Parameters.Clear();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                conn.desconectar();
            }
            return true;
        }
        public bool SetDadosEmpresa(int idEmpresa, string rua, string numeroEmpresa, string bairro, string cep, string cidade)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBenderecoEmpresa(id_Empresa,rua,numero_Empresa,bairro,cep_Empresa,cidade) VALUES(@idEmpresa,@rua,@numeroEmpresa,@bairro,@cep, @cidade)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@rua", rua);
                sqlCmd.Parameters.AddWithValue("@numeroEmpresa", numeroEmpresa);
                sqlCmd.Parameters.AddWithValue("@bairro", bairro);
                sqlCmd.Parameters.AddWithValue("@cep", cep);
                sqlCmd.Parameters.AddWithValue("@cidade", cidade);
                sqlCmd.ExecuteNonQuery();

                sqlCmd.Parameters.Clear();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                conn.desconectar();
            }
            return true;
        }     
        public bool SetDadosEmpresa(int idEmpresa, string tipoContatoEmpresa, string descricaoContatoEmpresa) 
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBcontatoEmpresa (id_Empresa,tipo_Contato,descricao_Contato) VALUES(@idEmpresa,@tipoContatoEmpresa, @descricaoContatoEmpresa)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@tipoContatoEmpresa", tipoContatoEmpresa);
                sqlCmd.Parameters.AddWithValue("@descricaoContatoEmpresa", descricaoContatoEmpresa);

                sqlCmd.ExecuteNonQuery();

                sqlCmd.Parameters.Clear();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                conn.desconectar();
            }
            return true;
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
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.desconectar();
            }
        }
    }
}