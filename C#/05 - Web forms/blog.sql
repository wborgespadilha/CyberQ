CREATE TABLE admins(
       id_admin INT PRIMARY KEY,
       usuario VARCHAR2(40),
       senha VARCHAR2(40)
);

CREATE SEQUENCE sequencia_admins
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_admins
BEFORE INSERT ON admins
FOR EACH ROW
BEGIN
    :new.id_admin := sequencia_admins.NEXTVAL;
END;


----------------------

CREATE TABLE categorias(
       id_categoria INT PRIMARY KEY,
       nome VARCHAR2(40)
);


CREATE SEQUENCE sequencia_categorias
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_categorias
BEFORE INSERT ON categorias
FOR EACH ROW
BEGIN
    :new.id_categoria := sequencia_categorias.NEXTVAL;
END;


--------------------

CREATE TABLE postagens(
       id_post INT PRIMARY KEY,
       titulo VARCHAR2(40),
       fk_categoria INT,
       texto VARCHAR2(256)
);

CREATE SEQUENCE sequencia_postagens
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_posts
BEFORE INSERT ON postagens
FOR EACH ROW
BEGIN
    :new.id_post := sequencia_postagens.NEXTVAL;
END;


















