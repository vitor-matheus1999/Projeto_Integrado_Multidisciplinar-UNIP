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
                    setor.SetCargaHoraria = dataReader.GetTimeSpan(dataReader.GetOrdinal("carga_Horaria"));
                    setor.SetSalarioGanhoHora = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Ganho_Em_Horas"));
                    setor.SetSalarioGanhoDia = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Diario"));

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
        public Setor GetDadosSetor(int idSetor)
        {
            {
                try
                {
                    sqlCmd.Connection = conn.conectar();
                    sqlCmd.CommandText = "SELECT id_Setor, id_Empresa,id_Salario,nome_Setor,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho,carga_Horaria,salario_Ganho_Em_Horas,salario_Diario FROM TBsetor WHERE id_Setor = @idSetor";
                    sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
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
                        setor.SetCargaHoraria = dataReader.GetTimeSpan(dataReader.GetOrdinal("carga_Horaria"));
                        setor.SetSalarioGanhoHora = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Ganho_Em_Horas"));
                        setor.SetSalarioGanhoDia = dataReader.GetDecimal(dataReader.GetOrdinal("salario_Diario"));

                        return new Setor(idSetor: setor.GetIdSetor, idEmpresa: setor.GetIdEmpresa, idSalario: setor.GetIdSalario, nomeSetor: setor.GetNomeSetor, hierarquia: setor.GetHierarquia, funcaoSetor: setor.GetFuncaoSetor, periodoTrabalho: setor.GetPeriodoTrabalho, escalaTrabalho: setor.GetEscalaTrabalho, cargaHoraria: setor.GetCargaHoraria, salarioGanhoHora: setor.GetSalarioGanhoHora, salaraioGanhoDia: setor.GetSalarioGanhoDia);
                    }
                    dataReader.Close();
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

                return new Setor();
            }
        }
        public bool SetDadosSetor(int idEmpresa, int idSalario, string nomeSetor, string hierarquia, string funcaoSetor,string periodoTrabalho, string escalaTrabalho, string cargaHoraria, decimal salarioGanhoHora, decimal salarioGanhoDia)
        {
            try
            {
                sqlCmd.CommandText = " INSERT INTO TBsetor (id_Empresa,id_Salario,nome_Setor,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho, carga_Horaria,salario_Ganho_Em_Horas,salario_Diario) VALUES (@idEmpresa,@idSalario, @nomeSetor,@hierarquia,@funcaoSetor,@periodoTrabalho,@escalaTrabalho, @cargaHoraria, @salarioGanhoHora, @salarioGanhoDia)";
                sqlCmd.Connection = conn.conectar();
                sqlCmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                sqlCmd.Parameters.AddWithValue("@idSalario", idSalario);
                sqlCmd.Parameters.AddWithValue("@nomeSetor", nomeSetor);
                sqlCmd.Parameters.AddWithValue("@hierarquia", hierarquia);
                sqlCmd.Parameters.AddWithValue("@funcaoSetor", funcaoSetor);
                sqlCmd.Parameters.AddWithValue("@periodoTrabalho", periodoTrabalho);
                sqlCmd.Parameters.AddWithValue("@escalaTrabalho", escalaTrabalho);
                sqlCmd.Parameters.AddWithValue("@cargaHoraria", cargaHoraria);
                sqlCmd.Parameters.AddWithValue("@salarioGanhoHora", salarioGanhoHora);
                sqlCmd.Parameters.AddWithValue("@salarioGanhoDia", salarioGanhoDia);
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
                sqlCmd.Parameters.AddWithValue("@nomeSetor", nomeSetor);
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
        public void GetFuncionariosSetorHierarquiaTextBox(TextBox setorFuncionario, TextBox nivelHierarquico, int idSetor)
        {
            try
            {
                sqlCmd.CommandText = "SELECT nome_Setor, hierarquia FROM TBsetor WHERE id_Setor = @idSetor";
                sqlCmd.Parameters.AddWithValue("@idSetor", idSetor);
                sqlCmd.Connection = conn.conectar();
                using (SqlDataReader dataReader = sqlCmd.ExecuteReader())
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