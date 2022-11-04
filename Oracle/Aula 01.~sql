-- Criar tabela
CREATE TABLE pessoas (
       nome VARCHAR2(20), 
       idade NUMBER
);




-- Inserir dados
INSERT INTO pessoas VALUES('Kelly Inguissa',27);




-- Selecionar todos os dados
SELECT * FROM pessoas;

-- Selecionar todos os dados especificando as colunas
SELECT nome FROM pessoas;

-- Contabilizar registros
SELECT COUNT(*) FROM pessoas;

-- Somar todas as idades
SELECT SUM(idade) FROM pessoas;

-- Média das idades
SELECT AVG(idade) FROM pessoas;

-- Maior idade
SELECT MAX(idade) FROM pessoas;

-- Menor idade
SELECT MIN(idade) FROM pessoas;

-- Filtrar dados utilizando WHERE
SELECT * FROM pessoas WHERE idade >= 20;

/*
       >   Maior
       <   Menor
       >=  Maior ou igual
       <=  Menor ou igual
       =   Igual
       <>  Diferente
*/

-- Operadores lógicos
SELECT * FROM pessoas WHERE nome = 'Isabela' OR nome = 'Tião';

/*
   E  - AND
   OU - OR
*/

-- Ordenar nomes (A - Z)
SELECT * FROM pessoas ORDER BY nome ASC;

-- Ordenar nomes (Z - A)
SELECT * FROM pessoas ORDER BY nome DESC;

-- Listar pessoas com idade ntre 20 e 30 anos
SELECT * FROM pessoas WHERE idade BETWEEN 20 AND 30;

-- Comando LIKE
SELECT nome FROM pessoas WHERE nome LIKE 'J%'; -- Inicial
SELECT nome FROM pessoas WHERE nome LIKE '%o'; -- Final
SELECT nome FROM pessoas WHERE nome LIKE '%o%'; -- Contêm




-- Alterar dados
UPDATE pessoas SET idade = 42 WHERE nome = 'João';

-- Remover dados
DELETE FROM pessoas WHERE idade < 18;

-- Excluir tabela
DROP TABLE pessoas;

-- Excluir banco de dados
DROP DATABASE;




