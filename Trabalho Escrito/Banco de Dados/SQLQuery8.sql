/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id_Contato_Funcionario]
      ,[id_Funcionario]
      ,[tipo_Contato_Funcionario]
      ,[descricao]
  FROM [BDfolhaDePagamento].[dbo].[TBcontatoFuncionario]


  INSERT INTO TBcontatoFuncionario (id_Funcionario, tipo_Contato_Funcionario, descricao) VALUES(2,'Email Empresarial','joao.silva_Empresa@empresa.com.br');