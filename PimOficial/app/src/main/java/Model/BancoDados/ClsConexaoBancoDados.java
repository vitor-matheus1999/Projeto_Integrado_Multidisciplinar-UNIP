package Model.BancoDados;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ClsConexaoBancoDados {

    public Connection conexaoSql(){

        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String bdUrl = "jdbc:sqlserver://DESKTOP-KV08MGN;databaseName=BDfolhaDePagamento;user=VITORM;password=Boal@90929965@.@;integratedSecurity=true";

            return DriverManager.getConnection(bdUrl);

        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
