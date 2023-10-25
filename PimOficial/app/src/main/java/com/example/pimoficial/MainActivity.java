package com.example.pimoficial;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import Model.BancoDados.ClsBancoDadosFuncionario;


public class MainActivity extends Activity
{

    ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
    private EditText Login;
    private EditText Senha;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login);

        Login = findViewById(R.id.Login);
        Senha = findViewById(R.id.Senha);
        Button loginButton = findViewById(R.id.loginButton);

        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String username = Login.getText().toString();
                String password = Senha.getText().toString();

                boolean isValid = bdFuncionario.GetLoginSenha(username, password);

                if (isValid == true) {

                    Toast.makeText(MainActivity.this,"Login Funcionou",Toast.LENGTH_SHORT).show();

                } else {
                    Toast.makeText(MainActivity.this,"Login NÃO FUNCIONOU",Toast.LENGTH_SHORT).show();

                }
            }
        });

    }
 private boolean ValidarLogin(String login, String senha){
     try {
         String connectionUrl = "jdbc:sqlserver://serverName:1433;databaseName=yourDatabase;user=yourUsername;password=yourPassword;";
         Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

         // Estabeleça uma conexão com o banco de dados
         Connection connection = DriverManager.getConnection(connectionUrl);

         // Crie uma consulta SQL parametrizada
         String sql = "SELECT * FROM tabela WHERE username = ? AND password = ?";
         // username será email ou matrícula, a senha pode ser tratada posteriormente
         PreparedStatement preparedStatement = connection.prepareStatement(sql);
         preparedStatement.setString(1, login);
         preparedStatement.setString(2, senha);

         // Execute a consulta
         ResultSet resultSet = preparedStatement.executeQuery();

         // Verifique se as credenciais são válidas com base no resultado da consulta
         if (resultSet.next()) {
             // Credenciais válidas
             return true;
         }
     } catch (ClassNotFoundException | SQLException e) {
         e.printStackTrace();
     }

     // Credenciais inválidas
     return false;
 }
}

