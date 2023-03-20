CREATE DATABASE EXERCICIO_SEMANA7
GO
USE EXERCICIO_SEMANA7

-- Exerc�cio 1

CREATE TABLE CLIENTE(
	ID INT,
	NOME VARCHAR(50),
	TELEFONE VARCHAR(12),
	ENDERECO VARCHAR(50)
)


-- Exerc�cio 2

INSERT INTO CLIENTE(ID, NOME, TELEFONE, ENDERECO) VALUES (1, 'Vinicius Silva' , '987654', 'Rua Girassol'), 
														 (2, 'Maria Antonia' , '123456' , 'Rua Rosas'), 
														 (3,'Marcus Vinicius', '654123', 'Rua Itajai')


-- Exerc�cio 3

SELECT * FROM CLIENTE


-- Exerc�cio 4

SELECT * FROM CLIENTE WHERE ID = 1
SELECT * FROM CLIENTE WHERE ID = 2
SELECT * FROM CLIENTE WHERE ID = 3


-- Exerc�cio 5

SELECT * FROM CLIENTE WHERE NOME LIKE 'Ma%'


-- Exerc�cio 6

UPDATE CLIENTE SET ENDERECO = 'Rua do Lim�o' WHERE ID = 3


-- Exerc�cio 7

DELETE CLIENTE WHERE ID = 2