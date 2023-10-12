using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using PIM4___WebHolerite.Models.Negócios;

namespace PIM4___WebHolerite.Models.Banco_de_Dados
{
    public class ClsBancoDadosSetor
    {
        ClsConexaoSql conn = new ClsConexaoSql();
        SqlCommand sqlCmd = new SqlCommand();
        Setor setor = new Setor();
        public List<Setor> listaSetores = new List<Setor>();

        public List<Setor> GetListaSetor()
        {
            try
            {                  
                sqlCmd.Connection = conn.conectar();
                sqlCmd.CommandText = "SELECT id_Empresa,id_Salario,nome_Setor,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho, carga_Horaria,salario_Ganho_Em_Horas,salario_Diario FROM TBsetor ";
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    setor.SetIdSetor = dataReader.GetInt32(dataReader.GetOrdinal("id_Setor"));
                    setor.SetIdEmpresa = dataReader.GetInt32(dataReader.GetOrdinal("id_Empresa"));
                    setor.SetIdSalario = dataReader.GetInt32(dataReader.GetOrdinal("id_Salario"));
                    setor.SetNomeSetor = dataReader.GetString(dataReader.GetOrdinal("nome_Setor"));
                    setor.SetHierarquia = dataReader.GetString(dataReader.GetOrdinal("hierarquia"));
                    setor.SetFuncaoSetor = dataReader.GetString(dataReader.GetOrdinal("funcao_Setor"));
                    setor.SetPeriodoTrabalho = dataReader.GetString(dataReader.GetOrdinal("periodo_Trabalho"));
                    setor.SetEscalaTrabalho = dataReader.GetString(dataReader.GetOrdinal("escala_Trabalho"));
                    setor.SetCargaHoraria = dataReader.GetDateTime(dataReader.GetOrdinal("carga_Horaria"));
                    setor.SetSalarioGanhoHora = dataReader.GetFloat(dataReader.GetOrdinal("salario_Ganho_Em_Horas"));
                    setor.SetSalarioGanhoDia = dataReader.GetFloat(dataReader.GetOrdinal("salario_Diario"));

                    listaSetores.Add(new Setor(idSetor: setor.GetIdSetor, idEmpresa: setor.GetIdEmpresa, idSalario: setor.GetIdSalario,  nomeSetor: setor.GetNomeSetor,  hierarquia: setor.GetHierarquia, funcaoSetor: setor.GetFuncaoSetor,  periodoTrabalho: setor.GetPeriodoTrabalho,  escalaTrabalho: setor.GetEscalaTrabalho, cargaHoraria: setor.GetCargaHoraria, salarioGanhoHora: setor.GetSalarioGanhoHora, salaraioGanhoDia: setor.GetSalarioGanhoDia));
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

            return listaSetores;
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
        public bool SetDadosSetor(int idEmpresa, int idSalario, string nomeSetor, string hierarquia, string funcaoSetor,string periodoTrabalho, string escalaTrabalho, string cargaHoraria)
        {
            try
            {
                sqlCmd.CommandText = " INSERT INTO TBsetor (id_Empresa,id_Salario,nome_Setor,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho, carga_Horaria,salario_Ganho_Em_Horas,salario_Diario) VALUES (@idEmpresa,@idSalario, @nomeSetor,@hierarquia,@funcaoSetor,@periodoTrabalho,@escalaTrabalho, @cargaHoraria, 0.00,0.00)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@idSalario", idSalario);
                sqlCmd.Parameters.AddWithValue("@nomeSetor", nomeSetor);
                sqlCmd.Parameters.AddWithValue("@hierarquia", hierarquia);
                sqlCmd.Parameters.AddWithValue("@funcaoSetor", funcaoSetor);
                sqlCmd.Parameters.AddWithValue("@periodoTrabalho", periodoTrabalho);
                sqlCmd.Parameters.AddWithValue("@escalaTrabalho", escalaTrabalho);
                sqlCmd.Parameters.AddWithValue("@cargaHoraria", cargaHoraria);
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
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