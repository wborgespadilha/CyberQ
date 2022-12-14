-- Criar tabela

CREATE TABLE usuarioz (
             codigo NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
             nome VARCHAR2(20),
             sobrenome VARCHAR2(50),
             cidade VARCHAR2(30)
);

-- Renomear tabela

ALTER TABLE usuarioz RENAME TO clientes;

-- Remover coluna

ALTER TABLE clientes DROP COLUMN sobrenome;

-- Adicionar coluna

ALTER TABLE clientes ADD nascimento DATE;

-- Chave primaria

ALTER TABLE clientes 
ADD CONSTRAINT codigo_cliente_pk
PRIMARY KEY (codigo);

-- Sequ?ncia "auto increment"

CREATE SEQUENCE codigo_cliente_pk
MINVALUE 1
MAXVALUE 999999999
START WITH 1
INCREMENT BY 1;

-- Inserir dados

INSERT INTO clientes (nome,cidade,nascimento) VALUES ( 'Alice', 'Joinville', TO_DATE('2006-01-28', 'yyyy-mm-dd'));

-- Pegar os dados

SELECT * FROM clientes;

-- Inserir v?rios dados de uma vez

INSERT ALL
  INTO clientes (nome,cidade,nascimento) VALUES ('Larissa', 'Curitiba', TO_DATE('1989-07-14', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('J?lio','Blumenau',TO_DATE('1992-03-04', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Marcelo','Blumenau',TO_DATE('1988-04-15', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Nat?lia','Florian?polis',TO_DATE('1994-12-02', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Caio','S?o Paulo',TO_DATE('1984-09-29', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Luan','Rio de Janeiro',TO_DATE('1997-09-30', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Paloma','Florian?polis',TO_DATE('1993-07-18', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Ol?via','Brusque',TO_DATE('1996-10-22', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Victor','Campinas',TO_DATE('2001-02-09', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Tatiana','S?o Paulo',TO_DATE('1990-02-04', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Rebeca','Curitiba',TO_DATE('1987-12-31', 'yyyy-mm-dd'))
  INTO clientes (nome,cidade,nascimento) VALUES ('Neila','Bras?lia',TO_DATE('1983-03-09', 'yyyy-mm-dd'))  
SELECT * from dual;

       -- OU 

INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Larissa', 'Curitiba', TO_DATE('1989-07-14', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('J?lio','Blumenau',TO_DATE('1992-03-04', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Marcelo','Blumenau',TO_DATE('1988-04-15', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Nat?lia','Florian?polis',TO_DATE('1994-12-02', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Caio','S?o Paulo',TO_DATE('1984-09-29', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Luan','Rio de Janeiro',TO_DATE('1997-09-30', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Paloma','Florian?polis',TO_DATE('1993-07-18', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Ol?via','Brusque',TO_DATE('1996-10-22', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Victor','Campinas',TO_DATE('2001-02-09', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Tatiana','S?o Paulo',TO_DATE('1990-02-04', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Rebeca','Curitiba',TO_DATE('1987-12-31', 'yyyy-mm-dd'));
INSERT INTO clientes (nome,cidade,nascimento) VALUES ('Neila','Bras?lia',TO_DATE('1983-03-09', 'yyyy-mm-dd'));

-- Pegar todos de blumenau

SELECT * FROM clientes WHERE cidade = 'Blumenau';

-- Pegar a quantidade de registros

SELECT COUNT (*) FROM clientes;

-- Pegar os nomes por ordem alfab?tica

SELECT nome FROM clientes ORDER BY nome ASC;

-- Pegar as cidades por ordem inversa

SELECT cidade FROM clientes ORDER BY cidade DESC;

-- Listar clientes nascidos a partir do ano 2000

SELECT * FROM clientes WHERE EXTRACT(YEAR FROM TO_DATE(nascimento)) >= 2000;

-- Selecionar as cidades sem repetir

SELECT cidade FROM clientes GROUP BY cidade;

-- Selecionar as cidades e numero de clientes em cada

SELECT cidade,COUNT (*) FROM clientes GROUP BY cidade;

-- Listar os com 30 ou mais anos

SELECT nome,nascimento,
EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento)) AS Idade 
FROM clientes 
WHERE
EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento)) >= 30;

-- Exibir os que o nome contenham L

SELECT nome FROM clientes WHERE nome LIKE '%l%' OR nome LIKE '%L%';

-- Exibir os que o nome comecem com  N

SELECT nome FROM clientes WHERE nome LIKE 'N%' OR nome LIKE 'n%';

-- Listar os que tem idade entre 20 e 30 anos

SELECT nome,nascimento,
EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento)) AS Idade 
FROM clientes 
WHERE
EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento)) BETWEEN 20 AND 30;

-- Mudar os de Brusque para Blumenau

UPDATE clientes SET cidade = 'Blumenau' WHERE cidade = 'Brusque';

-- Mostrar se ? ou n?o maior de idade

SELECT nome,
(EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento))) AS Idade ,
(CASE WHEN EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento)) >= 18 THEN 'Maior de idade' ELSE 'Menor di idade' END) AS situacao
FROM clientes;

-- Mostrar os que nasceram em setembro

SELECT COUNT(*)
FROM clientes 
WHERE
EXTRACT(MONTH FROM TO_DATE(nascimento)) = 9;

-- Soma de todas as idades

SELECT SUM(EXTRACT(YEAR FROM SYSDATE) - EXTRACT(YEAR FROM TO_DATE(nascimento))) AS soma
FROM clientes;

-- Listar todas que sejam curitiba ou florian?polis.

SELECT cidade FROM clientes WHERE cidade IN ('Curitiba','Florian?polis');

-- Excluir todos os registros de Blumenau

DELETE FROM clientes WHERE cidade = 'Blumenau';

-- Excluir a tabela

DROP TABLE clientes;


