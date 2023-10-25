package Model.BancoDados;


import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.ResultSet;
import java.util.List;
import Model.Negocio.Funcionario;
import Model.BancoDados.ClsConexaoBancoDados;

public class ClsBancoDadosFuncionario {
    Connection conn = new ClsConexaoBancoDados().conexaoSql();
    PreparedStatement sqlCmd;
    Funcionario funcionario = new Funcionario();
    List<Funcionario> listaFuncionario;
    public List<Funcionario> GetInformacoesFuncionarios() {
        try{
            String comandoSql= "SELECT id_Funcionario,id_Empresa, id_Setor,nome_Funcionario,data_nascimento,data_admissao,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras,holerite_Finalizado,funcionario_Arquivado FROM TBfuncionario";
            sqlCmd = conn.prepareStatement(comandoSql);
            ResultSet resultSet = sqlCmd.executeQuery();

            while(resultSet.next())
            {
                funcionario.setIdFuncionario(resultSet.getInt("id_Funcionario"));
                funcionario.setIdEmpresa(resultSet.getInt("id_Empresa"));
                funcionario.setIdSetor(resultSet.getInt("id_Setor"));
                funcionario.setNomeFuncionario(resultSet.getString("nome_Funcionario"));
                funcionario.setDataNascimento(resultSet.getDate("data_nascimento"));
                funcionario.setDataAdmissao(resultSet.getDate("data_admissao"));
                funcionario.setCpfFuncionario(resultSet.getString("cpf_Funcionario"));
                funcionario.setHorasNaoTrabalhadas(resultSet.getDouble("horas_Nao_Trabalhadas"));
                funcionario.setHorasExtras(resultSet.getDouble("horas_Extras"));
                funcionario.setSalarioSeraAcrescentadoDevidoHorasExtras(resultSet.getDouble("salario_Sera_Acrescentado_Devido_Horas_Extras"));
                funcionario.setHoleriteFinalizado(resultSet.getBoolean("holerite_Finalizado"));
                funcionario.setFuncionarioArquivado(resultSet.getBoolean("funcionario_Arquivado"));

                listaFuncionario.add(new Funcionario());
            }
            resultSet.close();
            sqlCmd.close();
            conn.close();
        } catch (SQLException e){
            throw new RuntimeException(e);
        }
        return listaFuncionario;
    }
    public Funcionario GetInformacaoFuncionario() {
        try{
            String comandoSql= "SELECT id_Funcionario,id_Empresa, id_Setor,nome_Funcionario,data_nascimento,data_admissao,sexo,cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras,holerite_Finalizado,funcionario_Arquivado FROM TBfuncionario";
            sqlCmd = conn.prepareStatement(comandoSql);
            ResultSet resultSet = sqlCmd.executeQuery();

            while(resultSet.next())
            {
                funcionario.setIdFuncionario(resultSet.getInt("id_Funcionario"));
                funcionario.setIdEmpresa(resultSet.getInt("id_Empresa"));
                funcionario.setIdSetor(resultSet.getInt("id_Setor"));
                funcionario.setNomeFuncionario(resultSet.getString("nome_Funcionario"));
                funcionario.setDataNascimento(resultSet.getDate("data_nascimento"));
                funcionario.setDataAdmissao(resultSet.getDate("data_admissao"));
                funcionario.setCpfFuncionario(resultSet.getString("cpf_Funcionario"));
                funcionario.setHorasNaoTrabalhadas(resultSet.getDouble("horas_Nao_Trabalhadas"));
                funcionario.setHorasExtras(resultSet.getDouble("horas_Extras"));
                funcionario.setSalarioSeraAcrescentadoDevidoHorasExtras(resultSet.getDouble("salario_Sera_Acrescentado_Devido_Horas_Extras"));
                funcionario.setHoleriteFinalizado(resultSet.getBoolean("holerite_Finalizado"));
                funcionario.setFuncionarioArquivado(resultSet.getBoolean("funcionario_Arquivado"));

                return new Funcionario();
            }
            resultSet.close();
            sqlCmd.close();
            conn.close();
        } catch (SQLException e){
            throw new RuntimeException(e);
        }
        return new Funcionario();
    }
    public Boolean GetLoginSenha(String login, String senha){
        try{
            String comandoSql= "SELECT contatoFunc.descricao, senhaLoginFuncRh.senha FROM TBsenhaLoginFuncionario AS senhaLoginFuncRh INNER JOIN TBcontatoFuncionario AS contatoFunc ON senhaLoginFuncRh.id_Contato_Funcionario = contatoFunc.id_Contato_Funcionario";
            sqlCmd = conn.prepareStatement(comandoSql);
            ResultSet resultSet = sqlCmd.executeQuery();
            while(resultSet.next()){
                funcionario.setDescricaoContato(resultSet.getString("descricao"));
                funcionario.setSenhaSistemaDesktop(resultSet.getString("senha"));

                funcionario = new Funcionario(funcionario.getDescricaoContato(), funcionario.getSenhaSistemaDesktop());
            }
            if(login.contains(funcionario.getDescricaoContato()) && senha.contains(funcionario.getSenhaSistemaDesktop()))
            {
                return true;
            }
            resultSet.close();
            sqlCmd.close();
            conn.close();
        }
        catch(SQLException exception){
            throw new RuntimeException(exception);
        }
        return false;
    }
}
