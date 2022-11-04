CREATE TABLE cidades(
       codigo_cidade NUMBER PRIMARY KEY,
       nome_cidade VARCHAR2(40)
);

CREATE SEQUENCE sequencia_cidade
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_cidades
BEFORE INSERT ON cidades
FOR EACH ROW
BEGIN
    :new.codigo_cidade := sequencia_cidade.NEXTVAL;
END;

SELECT * FROM cidades

TRUNCATE TABLE cidades
