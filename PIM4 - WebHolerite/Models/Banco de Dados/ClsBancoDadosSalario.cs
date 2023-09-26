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
                    salario.SetSalarioBruto = dataReader.GetDouble(dataReader.GetOrdinal("salario_Bruto"));
                    salario.SetSalarioLiquido = dataReader.GetDouble(dataReader.GetOrdinal("salario_Liquido"));
                    salario.SetDescontoFGTS = dataReader.GetFloat(dataReader.GetOrdinal("desconto_FGTS"));
                    salario.SetDescontoINSS = dataReader.GetFloat(dataReader.GetOrdinal("desconto_INSS"));
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
        public bool SetDadosSalario( int idEmpresa, double salarioBruto, double salarioLiquido,string descontoFGTS, float descontoINSS, float descontoValeTransporte, float descontoValeAlimentacao)
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
        public void GetEmpresasComboBox(ComboBox comboBoxEmpresa)
        {
            sqlCmd.CommandText = "SELECT id_Empresa, nome_Empresarial_Fantasia FROM TBempresa";

            try
            {
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