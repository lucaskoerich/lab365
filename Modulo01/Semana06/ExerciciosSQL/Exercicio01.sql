CREATE DATABASE VENDA
GO
USE VENDA

CREATE TABLE LUCAS(
	ID INT PRIMARY KEY NOT NULL,
	IDADE INT UNIQUE NOT NULL,
	CIDADE VARCHAR(MAX) NULL
)

ALTER TABLE LUCAS ADD UF CHAR(2), TELEFONE VARCHAR(12) NOT NULL

DROP TABLE LUCAS


CREATE TABLE VEICULO(
	ID INT PRIMARY KEY,
	DESCRICAO VARCHAR(100) NOT NULL,
	DATA_CRIACAO DATETIME NOT NULL,
	TIPO_MOTOR DECIMAL NOT NULL,
	VALOR SMALLMONEY NULL,
	VENDIDO BIT NOT NULL
)

CREATE TABLE COR(
	ID INT PRIMARY KEY NOT NULL,
	NOME_COR VARCHAR(100) UNIQUE NOT NULL
)

ALTER TABLE VEICULO ADD ID_COR INT REFERENCES COR(ID)
ALTER TABLE VEICULO ADD CONSTRAINT FK_COR FOREIGN KEY (ID_COR) REFERENCES COR(ID)

DROP TABLE COR

SELECT * FROM COR
SELECT * FROM VEICULO



