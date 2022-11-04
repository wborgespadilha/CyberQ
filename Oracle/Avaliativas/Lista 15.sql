--
CREATE TABLE "VENDEDOR" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CONTRATACAO" DATE NOT NULL,
  "SALARIO" FLOAT NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint VENDEDOR_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "VENDEDOR_CODIGO_SEQ";

 -- 1 º Trigger
CREATE OR REPLACE trigger "BI_VENDEDOR_CODIGO"
  before insert on "VENDEDOR"
  for each row
begin
  select "VENDEDOR_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "VENDAS" (
  "CODIGO" INT NOT NULL,
  "CODIGOVENDEDOR" INT NOT NULL,
  "CODIGOPRODUTO" INT NOT NULL,
  "QUANTIDADE" INT NOT NULL,
  "DATA" DATE NOT NULL,
  constraint VENDAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "VENDAS_CODIGO_SEQ";

 -- 2 º Trigger
CREATE trigger "BI_VENDAS_CODIGO"
  before insert on "VENDAS"
  for each row
begin
  select "VENDAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "ESTOQUES" (
  "CODIGO" INT NOT NULL,
  "CIDADE" VARCHAR2(50) NOT NULL,
  "ESTADO" VARCHAR2(50) NOT NULL,
  "BAIRRO" VARCHAR2(50) NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint ESTOQUE_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "ESTOQUES_CODIGO_SEQ";

 -- 3 º Trigger
CREATE trigger "BI_ESTOQUE_CODIGO"
  before insert on "ESTOQUES"
  for each row
begin
  select "ESTOQUES_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "LOJAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CIDADE" VARCHAR2(40) NOT NULL,
  "ESTADO" VARCHAR2(2) NOT NULL,
  "BAIRRO" VARCHAR2(50) NOT NULL,
  constraint LOJAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "LOJAS_CODIGO_SEQ";

 -- 4 º Trigger
CREATE trigger "BI_LOJAS_CODIGO"
  before insert on "LOJAS"
  for each row
begin
  select "LOJAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "MARCAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(40) NOT NULL,
  "FORNECEDOR" VARCHAR2(50) NOT NULL,
  constraint MARCAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "MARCAS_CODIGO_SEQ";

 -- 5 º Trigger
CREATE trigger "BI_MARCAS_CODIGO"
  before insert on "MARCAS"
  for each row
begin
  select "MARCAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "PRODUTOS" (
  "CODIGO" INT NOT NULL,
  "QUANTIDADE" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CODIGOESTOQUE" INT NOT NULL,
  "CODIGOMARCA" INT NOT NULL,
  constraint PRODUTOS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "PRODUTOS_CODIGO_SEQ";

 -- 6 º Trigger
CREATE trigger "BI_PRODUTOS_CODIGO"
  before insert on "PRODUTOS"
  for each row
begin
  select "PRODUTOS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

--
CREATE TABLE "GERENTES" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(50) NOT NULL,
  "CODIGOLOJA" INT NOT NULL,
  constraint GERENTES_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "GERENTES_CODIGO_SEQ";

 -- 7 º Trigger
CREATE trigger "BI_GERENTES_CODIGO"
  before insert on "GERENTES"
  for each row
begin
  select "GERENTES_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

CREATE TABLE "AUDITORIA"(
   "CODIGO" INT NOT NULL,
   "DATA" DATE NOT NULL,
   "OPERACAO" VARCHAR2(50) NOT NULL,
   "CODIGOPRODUTO" INT NOT NULL,
   "NOVAQUANTIA" INT,
   constraint AUDITORIA_PK PRIMARY KEY ("CODIGO"));
  

CREATE sequence "AUDITORIA_CODIGO_SEQ";

 -- 8 º Trigger
CREATE trigger "BI_AUDITORIA_CODIGO"
  before insert on "AUDITORIA"
  for each row
begin
  select "AUDITORIA_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

-- chaves estrangeiras

ALTER TABLE "VENDEDOR" ADD CONSTRAINT "VENDEDOR_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");
ALTER TABLE "VENDAS" ADD CONSTRAINT "VENDAS_fk0" FOREIGN KEY ("CODIGOVENDEDOR") REFERENCES "VENDEDOR"("CODIGO");
ALTER TABLE "VENDAS" ADD CONSTRAINT "VENDAS_fk1" FOREIGN KEY ("CODIGOPRODUTO") REFERENCES "PRODUTOS"("CODIGO");
ALTER TABLE "ESTOQUES" ADD CONSTRAINT "ESTOQUE_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");
ALTER TABLE "PRODUTOS" ADD CONSTRAINT "PRODUTOS_fk0" FOREIGN KEY ("CODIGOESTOQUE") REFERENCES "ESTOQUES"("CODIGO");
ALTER TABLE "PRODUTOS" ADD CONSTRAINT "PRODUTOS_fk1" FOREIGN KEY ("CODIGOMARCA") REFERENCES "MARCAS"("CODIGO");
ALTER TABLE "GERENTES" ADD CONSTRAINT "GERENTES_fk0" FOREIGN KEY ("CODIGOLOJA") REFERENCES "LOJAS"("CODIGO");

----------------------------------------------------------------------

-- 9 º Trigger
CREATE OR REPLACE TRIGGER descontar_estoque 
AFTER INSERT ON vendas
FOR EACH ROW
  DECLARE
  
  desconto NUMBER;
  codigoproduto NUMBER;
  
  BEGIN
  
    desconto := :new.quantidade;
    codigoproduto := :new.codigoproduto;
  
    UPDATE produtos SET quantidade = ((SELECT quantidade FROM produtos WHERE codigo = codigoproduto) - desconto) WHERE codigo = codigoproduto;
  
    END;
    

-- FOLLOWS

-- 10 º Trigger
CREATE OR REPLACE TRIGGER auditoria_desconto_estoque 
AFTER INSERT ON vendas
FOR EACH ROW
  FOLLOWS descontar_estoque
  DECLARE
  
  codigoproduto NUMBER;
  dataatual DATE;
  
  BEGIN
    
    codigoproduto := :new.codigoproduto;
    dataatual := CURRENT_DATE;
  
    INSERT INTO auditoria (data,operacao,codigoproduto,novaquantia) VALUES (dataatual,'Desconto/Nova Venda',codigoproduto,(SELECT quantidade FROM produtos WHERE codigo = codigoproduto));  
 
    END;
    
    
----------------------------------------------------------------------

INSERT INTO marcas (nome,fornecedor) VALUES ('Skol','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Kaiser','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Coca Cola','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Citrus','AMBEV');
INSERT INTO marcas (nome,fornecedor) VALUES ('Corona','AMBEV');

INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja1','Pomerode','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja2','Blumenau','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja3','Joinville','Centro','SC');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja4','São Paulo','Centro','SP');
INSERT INTO lojas (nome,cidade,bairro,estado) VALUES ('Loja5','Rio de Janeiro','Centro','RJ');

INSERT INTO GERENTES (nome,codigoloja) VALUES ('Jacinto',1);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Joana',2);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Juriscléia',3);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('José',4);
INSERT INTO GERENTES (nome,codigoloja) VALUES ('Janaína',5);

INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('Pomerode','Testo Rega','SC',1);
INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('Pomerode','Testo Alto','SC',1);
INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('Blumenau','Centro','SC',2);
INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('Joinville','Centro','SC',3);
INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('São Paulo','Capão Redondo','SP',4);
INSERT INTO estoques (cidade,bairro,estado,codigoloja) VALUES ('Rio de Janeiro','Centro','RJ',5);

INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,1,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,2,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA 600ML',800,3,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('LATA PURO MALTE 400ML',1000,3,1);
INSERT INTO produtos (nome,quantidade,codigoestoque,codigomarca) VALUES ('GARRAFA 40L',1200,3,1);


SELECT * FROM produtos;
SELECT * FROM auditoria;


INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Jaiminho',TO_DATE('2002-04-21','YYYY-MM-DD'),2700,1);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('João',TO_DATE('2006-02-11','YYYY-MM-DD'),2200,1);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Tião',TO_DATE('2004-06-22','YYYY-MM-DD'),3500,2);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Antônio',TO_DATE('2002-03-17','YYYY-MM-DD'),3000,3);
INSERT INTO vendedor (nome,contratacao,salario,codigoloja) VALUES ('Paulo',TO_DATE('2008-05-13','YYYY-MM-DD'),2000,4);

INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (1,1,500,TO_DATE('2022-06-22','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (1,2,700,TO_DATE('2022-09-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (3,4,700,TO_DATE('2022-10-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (3,5,250,TO_DATE('2022-12-25','YYYY-MM-DD'));
INSERT INTO vendas (codigovendedor,codigoproduto,quantidade,data) VALUES (4,7,900,TO_DATE('2022-08-12','YYYY-MM-DD'));


SELECT * FROM produtos;
SELECT * FROM auditoria;


---------------------------------------------------------------------------

DROP TABLE auditoria;
DROP TABLE vendas;
DROP TABLE vendedor;
DROP TABLE produtos;
DROP TABLE estoques;
DROP TABLE gerentes;
DROP TABLE lojas;
DROP TABLE marcas;

DROP SEQUENCE VENDEDOR_CODIGO_SEQ;
DROP SEQUENCE VENDAS_CODIGO_SEQ;
DROP SEQUENCE ESTOQUES_CODIGO_SEQ;
DROP SEQUENCE LOJAS_CODIGO_SEQ;
DROP SEQUENCE MARCAS_CODIGO_SEQ;
DROP SEQUENCE PRODUTOS_CODIGO_SEQ;
DROP SEQUENCE GERENTES_CODIGO_SEQ;
DROP SEQUENCE AUDITORIA_CODIGO_SEQ;
