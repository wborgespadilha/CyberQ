
CREATE TABLE "VENDEDOR" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CONTRATACAO" DATE NOT NULL,
  "SALARIO" FLOAT NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint VENDEDOR_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "VENDEDOR_CODIGO_SEQ";

CREATE trigger "BI_VENDEDOR_CODIGO"
  before insert on "VENDEDOR"
  for each row
begin
  select "VENDEDOR_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "VENDAS" (
  "CODIGO" INT NOT NULL,
  "CODIGOVENDEDOR" INT NOT NULL,
  "CODIGOPRODUTO" INT NOT NULL,
  "QUANTIDADE" INT NOT NULL,
  "DATA" DATE NOT NULL,
  constraint VENDAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "VENDAS_CODIGO_SEQ";

CREATE trigger "BI_VENDAS_CODIGO"
  before insert on "VENDAS"
  for each row
begin
  select "VENDAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "ESTOQUE" (
  "CODIGO" INT NOT NULL,
  "CIDADE" VARCHAR2(50) NOT NULL,
  "ESTADO" VARCHAR2(50) NOT NULL,
  "BAIRRO" VARCHAR2(50) NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint ESTOQUE_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "ESTOQUE_CODIGO_SEQ";

CREATE trigger "BI_ESTOQUE_CODIGO"
  before insert on "ESTOQUE"
  for each row
begin
  select "ESTOQUE_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "LOJAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CIDADE" VARCHAR2(40) NOT NULL,
  "ESTADO" VARCHAR2(2) NOT NULL,
  "BAIRRO" VARCHAR2(50) NOT NULL,
  constraint LOJAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "LOJAS_CODIGO_SEQ";

CREATE trigger "BI_LOJAS_CODIGO"
  before insert on "LOJAS"
  for each row
begin
  select "LOJAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "MARCAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(40) NOT NULL,
  "FORNECEDOR" VARCHAR2(50) NOT NULL,
  constraint MARCAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "MARCAS_CODIGO_SEQ";

CREATE trigger "BI_MARCAS_CODIGO"
  before insert on "MARCAS"
  for each row
begin
  select "MARCAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "PRODUTOS" (
  "CODIGO" INT NOT NULL,
  "QUANTIDADE" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CODIGOESTOQUE" INT NOT NULL,
  "CODIGOMARCA" INT NOT NULL,
  constraint PRODUTOS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "PRODUTOS_CODIGO_SEQ";

CREATE trigger "BI_PRODUTOS_CODIGO"
  before insert on "PRODUTOS"
  for each row
begin
  select "PRODUTOS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "RELACAO_VENDAS" (
  "NOMEVENDEDOR" VARCHAR2(50) NOT NULL,
  "PRODUTO" VARCHAR2(50) NOT NULL,
  "QUANTIDADE" INT NOT NULL,
  "DATA" DATE NOT NULL,
  "LOJA" VARCHAR2(50) NOT NULL);

/
-- Create (1) Crie a tabela gerentes, com as colunas 'codigo PK AI','nome VARCHAR2(50)','codigoloja int' 

CREATE TABLE "GERENTES" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint GERENTES_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "GERENTES_CODIGO_SEQ";

CREATE trigger "BI_GERENTES_CODIGO"
  before insert on "GERENTES"
  for each row
begin
  select "GERENTES_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
-- Rename (2) Renomeie a tabela estoque para estoques

ALTER TABLE "ESTOQUE" RENAME TO ESTOQUES;

-- ALTER (3) Adicione as chaves estrangeiras das tabelas

ALTER TABLE "VENDEDOR" ADD CONSTRAINT "VENDEDOR_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");

ALTER TABLE "VENDAS" ADD CONSTRAINT "VENDAS_fk0" FOREIGN KEY ("CODIGOVENDEDOR") REFERENCES "VENDEDOR"("CODIGO");
ALTER TABLE "VENDAS" ADD CONSTRAINT "VENDAS_fk1" FOREIGN KEY ("CODIGOPRODUTO") REFERENCES "PRODUTOS"("CODIGO");

ALTER TABLE "ESTOQUES" ADD CONSTRAINT "ESTOQUE_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");

ALTER TABLE "PRODUTOS" ADD CONSTRAINT "PRODUTOS_fk0" FOREIGN KEY ("CODIGOESTOQUE") REFERENCES "ESTOQUE"("CODIGO");
ALTER TABLE "PRODUTOS" ADD CONSTRAINT "PRODUTOS_fk1" FOREIGN KEY ("CODIGOMARCA") REFERENCES "MARCAS"("CODIGO");

ALTER TABLE "GERENTES" ADD CONSTRAINT "GERENTES_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");

ALTER TABLE "RELACAO_VENDAS" ADD CONSTRAINT "RELACAO_VENDAS_fk0" FOREIGN KEY ("NOMEVENDEDOR") REFERENCES "VENDEDOR"("NOME");
ALTER TABLE "RELACAO_VENDAS" ADD CONSTRAINT "RELACAO_VENDAS_fk1" FOREIGN KEY ("PRODUTO") REFERENCES "PRODUTOS"("NOME");
ALTER TABLE "RELACAO_VENDAS" ADD CONSTRAINT "RELACAO_VENDAS_fk2" FOREIGN KEY ("QUANTIDADE") REFERENCES "VENDAS"("QUANTIDADE");
ALTER TABLE "RELACAO_VENDAS" ADD CONSTRAINT "RELACAO_VENDAS_fk3" FOREIGN KEY ("DATA") REFERENCES "VENDAS"("DATA");
ALTER TABLE "RELACAO_VENDAS" ADD CONSTRAINT "RELACAO_VENDAS_fk4" FOREIGN KEY ("LOJA") REFERENCES "LOJAS"("NOME");

----------------------------------------------------------------------

INSERT INTO marcas (nome,fornecedor) VALUES ('Skol','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Kaiser','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Coca Cola','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Citrus','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Corona','AMBEV');

INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja1','Pomerode','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja2','Blumenau','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja3','Joinville','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja4','S�o Paulo','Centro','SP');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja5','Rio de Janeiro','Centro','RJ');

INSERT INTO GERENTES (nome,codigoloja) VALUES ('Jacinto',1);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Joana',2);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Juriscl�ia',3);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Jos�',4);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Jana�na',5);

INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('Pomerode','Testo Rega','SC',1);
INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('Pomerode','Testo Alto','SC',1);
INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('Blumenau','Centro','SC',2);
INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('Joinville','Centro','SC',3);
INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('S�o Paulo','Cap�o Redondo','SP',4);
INSERT INTO estoque (cidade,bairro,estado,codigoloja) VALUES ('Rio de Janeiro','Centro','RJ',5);

INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,3,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,3,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,3,1);

INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Jaiminho',TO_DATE('2002-04-21','YYYY-MM-DD'),2700,1);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Jo�o',TO_DATE('2006-02-11','YYYY-MM-DD'),2200,1);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Ti�o',TO_DATE('2004-06-22','YYYY-MM-DD'),3500,2);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Ant�nio',TO_DATE('2002-03-17','YYYY-MM-DD'),3000,3);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Paulo',TO_DATE('2008-05-13','YYYY-MM-DD'),2000,4);

INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (1,1,500,TO_DATE('2022-06-22','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (1,2,700,TO_DATE('2022-09-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (3,4,7000,TO_DATE('2022-10-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (3,5,250,TO_DATE('2022-12-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (4,7,900,TO_DATE('2022-08-12','YYYY-MM-DD'));

INSERT INTO relacao_vendas (nomevendedor,produto,quantidade,data,loja) VALUES ('Jaiminho','LATA 600ML',500,TO_DATE('2022-06-22','YYYY-MM-DD'),'Loja1');
INSERT INTO relacao_vendas (nomevendedor,produto,quantidade,data,loja) VALUES ('Jaiminho','LATA PURO MALTE 400ML',700,TO_DATE('2022-09-25','YYYY-MM-DD'),'Loja1');
INSERT INTO relacao_vendas (nomevendedor,produto,quantidade,data,loja) VALUES ('Ti�o','LATA 600ML',7000,TO_DATE('2022-10-25','YYYY-MM-DD'),'Loja2');
INSERT INTO relacao_vendas (nomevendedor,produto,quantidade,data,loja) VALUES ('Ti�o','LATA PURO MALTE 400ML',250,TO_DATE('2022-12-25','YYYY-MM-DD'),'Loja2');
INSERT INTO relacao_vendas (nomevendedor,produto,quantidade,data,loja) VALUES ('Ant�nio','LATA 600ML',900,TO_DATE('2022-08-12','YYYY-MM-DD'),'Loja3');

---------------------------------------------------------------------------


-- Inner Join (4) Liste as vendas com o nome do vendedor, do produto, quantidade e data pegando de cada tabela individual

SELECT 
vendedor.nome,
produtos.nome,
vendas.quantidade,
vendas.data
FROM vendas 

INNER JOIN vendedor
ON vendas.codigovendedor = vendedor.codigo

INNER JOIN produtos
ON vendas.codigoproduto = produtos.codigo;

-- Inner Join (5) Liste as vendas com o nome do vendedor, do produto, quantidade, data e loja pegando da tabela relacao_vendas

SELECT * 
FROM relacao_vendas;


-- LEFT JOIN/COUNT/GROUP BY (6) Listar todos os vendedores e sua quantidade de vendas, mesmo que n�o hajam vendas

SELECT 
vendedor.nome,
COUNT(vendas.codigo)
FROM vendedor

LEFT JOIN vendas
ON vendedor.codigo = vendas.codigovendedor

GROUP BY vendedor.nome; 

-- Sum (7) Mostrar quantos produtos h� em cada estoque

SELECT 
estoques.codigo,
SUM(produtos.quantidade)
FROM estoques

LEFT JOIN produtos
ON produtos.codigoestoque = estoques.codigo

GROUP BY estoques.codigo;

-- Average (8) M�dia de quantidade de produtos de cada estoque

SELECT 
estoques.codigo,
AVG(produtos.quantidade)
FROM estoques

LEFT JOIN produtos
ON produtos.codigoestoque = estoques.codigo

GROUP BY estoques.codigo;

-- Min/Subquery (9)  Mostrar a VENDA MAIS ANTIGA


SELECT 
vendedor.nome,
produtos.nome,
vendas.quantidade,
vendas.data
FROM vendas 

INNER JOIN vendedor
ON vendas.codigovendedor = vendedor.codigo

INNER JOIN produtos
ON vendas.codigoproduto = produtos.codigo

WHERE vendas.data = (SELECT MIN(vendas.data) FROM vendas);


-- Max/Subquery (10) Mostrar a VENDA MAIS RECENTE


SELECT 
vendedor.nome,
produtos.nome,
vendas.quantidade,
vendas.data
FROM vendas 

INNER JOIN vendedor
ON vendas.codigovendedor = vendedor.codigo

INNER JOIN produtos
ON vendas.codigoproduto = produtos.codigo

WHERE vendas.data = (SELECT MAX(vendas.data) FROM vendas);

-- Order by (11) Listar as vendas da mais recente para a mais antiga

SELECT 
vendedor.nome,
produtos.nome,
vendas.quantidade,
vendas.data
FROM vendas 

INNER JOIN vendedor
ON vendas.codigovendedor = vendedor.codigo

INNER JOIN produtos
ON vendas.codigoproduto = produtos.codigo

ORDER BY vendas.data DESC;


-- Where (12) LISTE AS VENDAS DO VENDEDOR JAIMINHO

SELECT 
vendedor.nome,
produtos.nome,
vendas.quantidade,
vendas.data
FROM vendas 

INNER JOIN vendedor
ON vendas.codigovendedor = vendedor.codigo

INNER JOIN produtos
ON vendas.codigoproduto = produtos.codigo

WHERE vendedor.nome = 'Jaiminho';

-- Between/AND (13) PRODUTO COM ESTOQUE ENTRE CERTAS QUANTIDADES

SELECT 
produtos.nome,
produtos.quantidade,
estoques.codigo
FROM produtos

LEFT JOIN estoques
ON produtos.codigoestoque = estoques.codigo

WHERE produtos.quantidade BETWEEN 900 AND 1100;


-- OR (14) Listar as vendas da loja1 e da loja3

SELECT * 
FROM relacao_vendas
WHERE relacao_vendas.loja = 'Loja1' OR relacao_vendas.loja = 'Loja3';

-- In (15) Pegue os nomes das lojas de blumenau,pomerode e s�o paulo usando IN

SELECT
nome,
lojas.cidade
FROM lojas
WHERE lojas.cidade IN ('Blumenau','Pomerode','S�o Paulo');


-- Like (16) LISTE PRODUTOS COM NOMES PARECIDOS (lata)

SELECT *
FROM produtos
WHERE UPPER(produtos.nome) LIKE UPPER('%lata%');

-- Union (17) Mostre as vendas do jaiminho e do ti�o usando union

SELECT * 
FROM relacao_vendas 
WHERE relacao_vendas.nomevendedor = 'Jaiminho'
UNION
SELECT * 
FROM relacao_vendas 
WHERE relacao_vendas.nomevendedor = 'Ti�o';


-- CASE (18) Mostre o estoque dos produtos, coloque estoque baixo caso esteja abaixo de 1000 e adequado caso maior


SELECT
produtos.nome,
(lojas.nome) AS loja,
(produtos.codigoestoque) AS estoque,
(CASE WHEN produtos.quantidade < 1000 THEN 'Estoque baixo' ELSE 'Estoque adequado' END) AS situacao_estoque
FROM produtos

INNER JOIN estoque
ON produtos.codigoestoque = estoque.codigo

INNER JOIN lojas
ON estoque.codigoloja = lojas.codigo;


-- Distinct (19) Mostrar todos os produtos disponiveis sem repeti��o de nome

SELECT DISTINCT
nome
FROM produtos;

-- Inner Join (20) Mostre os gerentes e suas respectivas lojas

SELECT 
(lojas.nome) AS loja,
gerentes.nome
FROM gerentes

INNER JOIN lojas
ON gerentes.codigoloja = lojas.codigo;

-- Inner Join (21) Mostre o gerente de cada vendedor

SELECT 
vendedor.nome,
(gerentes.nome) AS gerente
FROM vendedor

INNER JOIN lojas
ON vendedor.codigoloja = lojas.codigo

INNER JOIN gerentes
ON lojas.codigo = gerentes.codigoloja;

-- Inner Join (22) Mostre o gerente respons�vel por cada venda

SELECT 
relacao_vendas.produto,
relacao_vendas.quantidade,
relacao_vendas.data,
relacao_vendas.loja,
(gerentes.nome) AS gerente
FROM relacao_vendas

INNER JOIN lojas
ON relacao_vendas.loja = lojas.nome

INNER JOIN gerentes
ON lojas.codigo = gerentes.codigoloja;

-- Inner Join (23) Liste as marcas presentes em cada estoque

SELECT
estoques.codigo,
marcas.nome
FROM estoques

INNER JOIN lojas
ON estoques.codigoloja = lojas.codigo

INNER JOIN produtos
ON estoques.codigo = produtos.codigoestoque

INNER JOIN marcas
ON produtos.codigomarca = marcas.codigo;



-- Inner Join (24) Mostre as vendas por marca

SELECT 
marcas.nome,
relacao_vendas.produto
FROM relacao_vendas

INNER JOIN produtos
ON relacao_vendas.produto = produtos.nome

INNER JOIN marcas
ON produtos.codigomarca = marcas.codigo


-- Drop (25) Excluir todas as tabelas

DROP TABLE relacao_vendas;
DROP TABLE vendas;
DROP TABLE vendedor;
DROP TABLE produtos;
DROP TABLE estoques;
DROP TABLE gerentes;
DROP TABLE lojas;
DROP TABLE marcas;
