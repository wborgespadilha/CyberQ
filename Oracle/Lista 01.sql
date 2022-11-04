CREATE TABLE clientes (
       nome VARCHAR2(40),
       cidade VARCHAR2(20),
       idade NUMBER
);

INSERT INTO clientes VALUES ('Érica','Curitiba',28);
INSERT INTO clientes VALUES ('Lucas','Blumenau',16);
INSERT INTO clientes VALUES ('Larissa','Florianópolis',36);
INSERT INTO clientes VALUES ('Murilo','Joinville',23);
INSERT INTO clientes VALUES ('Cristiane','Blumenau',31);
INSERT INTO clientes VALUES ('Robson','Joinvile',42);
INSERT INTO clientes VALUES ('Mariana',NULL,37);
INSERT INTO clientes VALUES ('Jean','Blumenau',43);
INSERT INTO clientes VALUES ('Luana','Pomerode',19);
INSERT INTO clientes VALUES ('Cleber','Brusque',34);
INSERT INTO clientes VALUES ('Hellen','Blumenau',28);
INSERT INTO clientes VALUES ('Paulo','Joinville',44);
INSERT INTO clientes VALUES ('Alessandra','São Paulo',28);
INSERT INTO clientes VALUES ('Dênis','Blumenau',37);
INSERT INTO clientes VALUES ('Bianca','Campinas',23);
INSERT INTO clientes VALUES ('Gabriel','São Paulo',26);

-- Selecionar todos os registros

SELECT * FROM clientes;

-- Contar quantos registros

SELECT COUNT(*) FROM clientes;

-- Retornar pessoa com a maior idade

SELECT nome,
(SELECT MAX(idade) FROM clientes) AS idade 
FROM clientes;

-- Exibir todas as cidades registradas sem repetição

SELECT cidade FROM clientes GROUP BY cidade;

-- Exibir as cidades registradas e a quantia de moradores

SELECT cidade, COUNT(*) AS moradores FROM clientes GROUP BY cidade;

-- Exibir pessoas da cidade nula

SELECT nome,idade FROM clientes WHERE cidade IS NULL;

-- Exibir a média das idades

SELECT (SUM(idade)/COUNT(*))AS media FROM clientes;
SELECT AVG(idade) AS media FROM clientes;

-- Nome e idade da pessoa mais nova

SELECT nome,
(SELECT MIN(idade) FROM clientes) AS idade 
FROM clientes;

-- Nome e idade dos que tenham idade maior ou igual a media <<<<<<<<<<<<<<<<<<<<<<

SELECT
(CASE WHEN idade >= (SELECT SUM(idade)/COUNT(*) FROM clientes) THEN nome END) AS nome,
(CASE WHEN idade >= (SELECT SUM(idade)/COUNT(*) FROM clientes) THEN idade END) AS idade
FROM clientes;

SELECT nome, idade FROM clientes WHERE idade > (SELECT AVG(idade) FROM clientes)

-- Listar os entre 20 e 30 anos

SELECT * FROM clientes WHERE idade BETWEEN 20 AND 30;

-- Listar os blumenauenses acima de 30

SELECT * FROM clientes WHERE cidade = 'Blumenau' AND idade >= 30;

-- Listar os clientes de florianópolis ou curitiba

SELECT * FROM clientes WHERE cidade = 'Florianópolis' OR cidade = 'Curitiba';

-- Listar o nome dos clientes que contenham a letra L

SELECT * FROM clientes WHERE nome LIKE '%L%' OR nome LIKE '%l%'

-- Exibir os nomes em ordem alfabética

SELECT nome FROM clientes ORDER BY nome ASC;

-- Mudar de null para blumenau

UPDATE clientes SET cidade = 'Blumenau' WHERE cidade IS NULL;

-- Excluir os clientes que não são de bnu

DELETE clientes WHERE cidade != 'Blumenau';

-- Excluir tabela

DROP TABLE clientes;






