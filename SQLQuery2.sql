CREATE TABLE TBsenhaLoginFuncionario(
id_Senha_Funcionario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
id_Contato_Funcionario INT NOT NULL,
senha VARCHAR(30) NOT NULL
CONSTRAINT fkFuncionarioSenha_id_Funcionario FOREIGN KEY (id_Contato_Funcionario) REFERENCES TBfuncionario(id_Contato_Funcionario) 
);
USE BDfolhaDePagamento
SELECT * FROM TBcontatoFuncionario
SELECT * FROM TBcontatoEmpresa
SELECT * FROM TBenderecoEmpresa
SELECT funcionario_Arquivado FROM TBfuncionario
SELECT * FROM TBempresa
SELECT * FROM TBsalario
SELECT * FROM TBsetor
SELECT * FROM TBsocios
SELECT * FROM TBadministradores
SELECT * FROM TBsenhaLoginFuncionario

UPDATE TBsenhaLoginFuncionario SET senha = 123 WHERE 

SELECT contatoFunc.descricao, senhaLoginFuncRh.senha FROM TBsenhaLoginFuncionario AS senhaLoginFuncRh INNER JOIN TBcontatoFuncionario AS contatoFunc ON senhaLoginFuncRh.id_Contato_Funcionario = contatoFunc.id_Contato_Funcionario


SELECT * FROM TBenderecoFuncionario
DELETE FROM TBempresa WHERE id_Empresa = 3;

SELECT * FROM TBenderecoEmpresa

INSERT INTO TBcontatoFuncionario(id_Funcionario,  tipo_Contato_Funcionario, descricao) VALUES(1,'Email Empresarial','vitormatheusob@gmail.com')

SELECT id_Funcionario FROM TBfuncionario WHERE id_Empresa = 1 AND id_Setor = 1 AND  nome_Funcionario = 'Antonio Conselheiro ' AND cpf_Funcionario = '45678912354'

INSERT INTO TBfuncionario(id_Empresa,id_Setor, nome_Funcionario, data_nascimento, data_admissao, sexo , cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras,salario_Sera_Acrescentado_Devido_Horas_Extras,holerite_Finalizado, funcionario_Arquivado) VALUES(1,1, 'Joao Damassa', '11-12-1984','11/10/2020','m', '12345678913',0, 0, 0, 0, 0 )
SELECT id_Funcionario FROM TBfuncionario WHERE id_Empresa = 1 AND id_Setor = 1 AND  nome_Funcionario = 'Vivilan Assunção' AND cpf_Funcionario = '12345678913'
INSERT INTO TBfuncionario(id_Empresa,id_Setor, nome_Funcionario, data_nascimento, data_admissao, sexo , cpf_Funcionario,horas_Nao_Trabalhadas,horas_Extras) VALUES(1,1, 'Dayane Andrade', '11/12/1999','11/10/2020','m', '12345678910', 0, 0 );

USE BDfolhaDePagamento

DROP TABLE TBsenhaFuncionario;
DROP TABLE TBcontatoFuncionario;
DROP TABLE TBenderecoFuncionario;
DROP TABLE TBadministradores;
DROP TABLE TBfuncionario


INSERT INTO TBsenhaFuncionario(id_Funcionario, senha) VALUES(1, '123')

CREATE DATABASE BDfolhaDePagamento
DROP DATABASE BDfolhaDePagamento

USE BDfolhaDePagamento

DROP TABLE TBcontatoSocios

CREATE TABLE TBsocios
(
	id_Socios INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	tipo_socio VARCHAR(60) NOT NULL,
	nome VARCHAR(50),
	tipo_Registro_Receita_Federal VARCHAR(50) NOT NULL,
	descricao_Registro_Receita_Federal VARCHAR(25) NOT NULL,
	CONSTRAINT fk_id_Empresa FOREIGN KEY(id_Empresa) REFERENCES TBempresa(id_Empresa)
);


CREATE TABLE TBadministradores
(
	id_Administradores INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	id_Funcionario INT NOT NULL,
	CONSTRAINT fk_id_Empresa_ADM FOREIGN KEY(id_Empresa) REFERENCES TBempresa(id_Empresa),
	CONSTRAINT fk_id_Funcionario FOREIGN KEY(id_Funcionario) REFERENCES TBfuncionario(id_Funcionario)
);

CREATE TABLE TBcontatoEmpresa
(
	id_Contato_Empresa INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	tipo_Contato VARCHAR(40) NOT NULL,
	descricao_Contato VARCHAR (50) NOT NULL,
	CONSTRAINT fk_id_Empresa_Contato FOREIGN KEY(id_Empresa) REFERENCES TBempresa(id_Empresa)
);

CREATE TABLE TBempresa
(
	id_Empresa INT identity(1,1) PRIMARY KEY NOT NULL,
	nome_Empresarial_Fantasia VARCHAR(100) NOT NULL,
	CNAE VARCHAR (14) NOT NULL,
	CNPJ VARCHAR(14) NOT NULL,
	situacao_Cadastral VARCHAR(10) NOT NULL,
	natureza_Juridica VARCHAR(50) NOT NULL,
	data_Abertura DATE NOT NULL,
	atividades_Economicas VARCHAR(200) NOT NULL,
);

CREATE TABLE TBcontatoFuncionario
(
	id_Contato_Funcionario INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Funcionario INT NOT NULL ,
	tipo_Contato_Funcionario VARCHAR(40) NOT NULL,
	descricao VARCHAR(50) NOT NULL,
	CONSTRAINT fk_id_Funcionario_Contato FOREIGN KEY(id_Funcionario) REFERENCES TBfuncionario(id_Funcionario)
);

INSERT INTO TBcontatoFuncionario (id_Funcionario, tipo_Contato_Funcionario, descricao) VALUES (1, 'Enail Empresarial', 'joao.silva_Empresa@empresa.com.br');

CREATE TABLE TBfuncionario
(
	id_Funcionario INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	id_Setor INT NOT NULL ,
	nome_Funcionario VARCHAR(60) NOT NULL,
	data_nascimento DATE NOT NULL,
	data_admissao DATE NOT NULL,
	sexo VARCHAR(2) NOT NULL,
	cpf_Funcionario VARCHAR(14) NOT NULL,
	horas_Nao_Trabalhadas FLOAT,
	horas_Extras FLOAT,
	salario_Sera_Acrescentado_Devido_Horas_Extras DECIMAL,
	holerite_Finalizado BIT,
	funcionario_Arquivado BIT,
	CONSTRAINT fk_id_Funcionario_Empresa FOREIGN KEY (id_Empresa) REFERENCES TBempresa(id_Empresa),
	CONSTRAINT fk_id_Funcionario_Setor FOREIGN KEY (id_Setor) REFERENCES TBsetor(id_Setor),
);

CREATE TABLE TBenderecoFuncionario
(
	id_Endereco_Funcionario INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Funcionario INT NOT NULL,
	rua VARCHAR(60) NOT NULL,
	numero_moradia VARCHAR(20)NOT NULL,
	bairro VARCHAR(60) NOT NULL ,
	cep_residencia VARCHAR(9) NOT NULL,
	cidade VARCHAR(40) NOT NULL,
	CONSTRAINT fk_id_Funcionario_Endereco FOREIGN KEY (id_Funcionario) REFERENCES TBfuncionario(id_Funcionario)
);

CREATE TABLE TBenderecoEmpresa
(
	id_Endereco_Empresa INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	rua VARCHAR(60) NOT NULL,
	numero_Empresa VARCHAR(20)NOT NULL,
	bairro VARCHAR(60) NOT NULL ,
	cep_Empresa VARCHAR(8) NOT NULL,
	cidade VARCHAR(40) NOT NULL,
	CONSTRAINT fk_id_Empresa_Endereco FOREIGN KEY (id_Empresa) REFERENCES TBempresa(id_Empresa)
);

CREATE TABLE TBsetor
(
	id_Setor INT identity(1,1) PRIMARY KEY NOT NULL,
	id_Empresa INT NOT NULL,
	id_Salario INT NOT NULL,
	nome_Setor VARCHAR (30),
	hierarquia VARCHAR (200) NOT NULL,
	funcao_Setor VARCHAR(60) NOT NULL,
	periodo_Trabalho VARCHAR(10) NOT NULL,
	escala_Trabalho VARCHAR(20) NOT NULL,
	carga_Horaria TIME NOT NULL,
	salario_Ganho_Em_Horas DECIMAL (12,2) NOT NULL,
	salario_Diario DECIMAL(12,2) NOT NULL
	CONSTRAINT fk_id_Salario FOREIGN KEY(id_Salario) REFERENCES TBsalario(id_Salario),
	CONSTRAINT fk_id_Empresa_Setor FOREIGN KEY(id_Empresa) REFERENCES TBempresa(id_Empresa)
);
DROP TABLE TBsetor
INSERT INTO TBsetor (id_Empresa,id_Salario,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho, carga_Horaria,salario_Ganho_Em_Horas,salario_Diario)VALUES(1,	1,	'Junior',	'Analista de Dados','M/T','5/2', '8:00:00',0,0);
INSERT INTO TBsetor (id_Empresa,id_Salario,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho,carga_Horaria,salario_Ganho_Em_Horas,salario_Diario)VALUES(1,	2,	'Senior',	'Recursos Humanos',	'T/N','5/2',	'8:00:00',0,0);
INSERT INTO TBsetor (id_Empresa,id_Salario,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho,carga_Horaria,salario_Ganho_Em_Horas,salario_Diario)VALUES(2,	3,	'Pleno',	'Técnico de informática','M/T','5/2', '8:00:00',0,0);
INSERT INTO TBsetor (id_Empresa,id_Salario,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho,carga_Horaria,salario_Ganho_Em_Horas,salario_Diario)VALUES(2,	4,	'Senior',	'Recursos Humanos',	'M/T','5/2',	'8:00:00',0,0);
INSERT INTO TBsetor (id_Empresa,id_Salario,hierarquia,funcao_setor,periodo_Trabalho,escala_Trabalho,carga_Horaria,salario_Ganho_Em_Horas,salario_Diario)VALUES(1,	5,	'Estágio','Analista de Dados',	'M/T','5/2',	'6:00:00',0,0);





INSERT INTO TBsetor (id_Empresa,id_Salario,nome_Setor,hierarquia,funcao_setor,periodo_Trabalho,carga_Horaria)VALUES(1,	1,'Informática', 	'Junior',	'Analista de Dados',	'M/T',	'08:00:00.0000000');

CREATE TABLE TBsalario
(
	id_Salario INT identity(1,1) PRIMARY KEY NOT NULL,
	id_empresa INT,
	salario_Bruto DECIMAL (12,2) NOT NULL,
	salario_Liquido DECIMAL (12,2) NOT NULL,
	desconto_FGTS VARCHAR(3) NOT NULL,
	desconto_INSS FLOAT NOT NULL,
	desconto_Vale_Transporte FLOAT NOT NULL,
	desconto_Vale_Alimentacao FLOAT ,
	CONSTRAINT fk_Empresa FOREIGN KEY (id_Empresa) REFERENCES TBempresa(id_Empresa)
);

INSERT INTO TBsalario (id_empresa,salario_Bruto,salario_Liquido,desconto_FGTS,desconto_INSS,desconto_Vale_Alimentacao,desconto_Vale_Transporte)VALUES(1, 3500.00, 2520.00, 'SIM',	12, 6, 10);
INSERT INTO TBsalario (id_empresa,salario_Bruto,salario_Liquido,desconto_FGTS,desconto_INSS,desconto_Vale_Alimentacao,desconto_Vale_Transporte)VALUES(1, 4800.00, 3264.00, 'SIM',	14, 6, 12);

INSERT INTO TBsalario (id_empresa,salario_Bruto,salario_Liquido,desconto_FGTS,desconto_INSS,desconto_Vale_Alimentacao,desconto_Vale_Transporte)VALUES(2, 6200.00, 4340.00, 'SIM',	14, 6, 10);

INSERT INTO TBsalario (id_empresa,salario_Bruto,salario_Liquido,desconto_FGTS,desconto_INSS,desconto_Vale_Alimentacao,desconto_Vale_Transporte)VALUES(2, 5000.00, 3450.00, 'SIM',	14, 6, 11);


DROP TABLE TBsalario
BACKUP DATABASE BDfolhaDePagamento TO DISK ='E:\sql server\BancoDadosFolhaDePagamento.BAK'

SELECT id_Funcionario FROM TBfuncionario WHERE id_Empresa = '1' AND id_Setor = '1' AND cpf_Funcionario = '12345678910';
SELECT id_Funcionario FROM TBfuncionario WHERE id_Empresa = 1 AND id_Setor = 1 AND  nome_Funcionario = 'Agatha Christie da Silva' AND data_nascimento = '1991-03-14' AND data_admissao = '2023-09-09' AND sexo = 'M' AND cpf_Funcionario = '@12314745612'

