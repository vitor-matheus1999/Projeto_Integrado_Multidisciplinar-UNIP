using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using PIM4___WebHolerite.Models.Negócios;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsBancoDadosSalario
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();
        List<Salario> listaSalarios = new List<Salario>();
        Salario salario = new Salario();

        public List<Salario> GetSalarios()
        {
            try
            {
                sqlCmd.CommandText = "SELECT id_Salario, id_Empresa, salario_Bruto, salario_Liquido, desconto_FGTS, desconto_INSS,desconto_Vale_Transporte,desconto_Vale_Alimentacao FROM TBsalario";
                sqlCmd.Connection = conn.conectar();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    salario.SetIdSalario = dataReader.GetInt32(dataReader.GetOrdinal("id_Salario"));
                    salario.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                    salario.SetSalarioBruto = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Bruto"));
                    salario.SetSalarioLiquido = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Liquido"));
                    salario.SetDescontoFGTS = dataReader.GetDecimal(dataReader.GetOrdinal("desconto_FGTS"));
                    salario.SetDescontoINSS = dataReader.GetDecimal(dataReader.GetOrdinal("desconto_INSS"));
                    salario.SetDescontoValeTransporte = dataReader.GetFloat(dataReader.GetOrdinal("desconto_Vale_Transporte"));
                    salario.SetDescontoValeAlimentacao = dataReader.GetFloat(dataReader.GetOrdinal("desconto_Vale_Alimentacao"));

                    listaSalarios.Add(new Salario(idSalario: salario.GetIdSalario, idEmpresa: salario.GetIdEmpresa,salarioBruto: salario.GetSalarioBruto, salarioLiquido: salario.GetSalarioLiquido,descontoFGTS: salario.GetDescontoFGTS, descontoINSS: salario.GetDescontoINSS, descontoValeTransporte: salario.GetDescontoValeTransporte, descontoValeAlimentacao: salario.GetDescontoValeAlimentacao));
                }
                dataReader.Close();
            }
            catch(SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conn.desconectar();
            }
            return listaSalarios;
        }
        public bool SetDadosSalario( int idEmpresa, decimal salarioBruto, decimal salarioLiquido,string descontoFGTS, decimal descontoINSS, float descontoValeTransporte, float descontoValeAlimentacao)
        {
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO TBsalario(id_empresa,salario_Bruto,salario_Liquido,desconto_FGTS,desconto_INSS,desconto_Vale_Alimentacao,desconto_Vale_Transporte) VALUES( @idEmpresa,@salarioBruto,@salarioLiquido,@descontoFGTS,@descontoINSS,@descontoValeTransporte, @descontoValeAlimentacao)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@salarioBruto", salarioBruto);
                sqlCmd.Parameters.AddWithValue("@salarioLiquido", salarioLiquido);
                sqlCmd.Parameters.AddWithValue("@descontoFGTS", descontoFGTS);
                sqlCmd.Parameters.AddWithValue("@descontoINSS", descontoINSS);
                sqlCmd.Parameters.AddWithValue("@descontoValeTransporte", descontoValeTransporte);
                sqlCmd.Parameters.AddWithValue("@descontoValeAlimentacao", descontoValeAlimentacao);
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
        public void GetSalariosComboBox(ComboBox comboBoxSalario, int idEmpresa)
        {
            sqlCmd.CommandText = "SELECT id_Salario, salario_Bruto FROM TBsalario WHERE id_Empresa = @idEmpresa";
            sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
            try
            {
                sqlCmd.Connection = conn.conectar();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCmd;
                DataTable tabela = new DataTable();
                tabela.Columns.Add("salario_Bruto", typeof(String));
                tabela.Columns.Add("id_Salario", typeof(Int32));
                dataAdapter.Fill(tabela);

                DataRow itemLinha = tabela.NewRow();
                itemLinha[0] = "Selecione o salário";
                tabela.Rows.InsertAt(itemLinha, 0);

                comboBoxSalario.DataSource = tabela;
                comboBoxSalario.DisplayMember = "salario_Bruto";
                comboBoxSalario.ValueMember = "id_Salario";
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

        public Salario GetSalario(int idSalario)
        {
            try
            {
                sqlCmd.CommandText = "SELECT salario_Bruto, salario_Liquido FROM TBsalario WHERE id_Salario = @idSalario";
                sqlCmd.Parameters.AddWithValue("@idSalario", idSalario);
                sqlCmd.Connection = conn.conectar();

                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        salario.SetSalarioBruto = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Bruto"));
                        salario.SetSalarioLiquido = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Liquido"));
                     
                        return new Salario(salarioBruto: salario.GetSalarioBruto, salarioLiquido:salario.GetSalarioLiquido);
                    }
                    dataReader.Close();
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

            return new Salario();
        }
    }
}