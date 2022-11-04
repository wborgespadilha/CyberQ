CREATE TABLE alunos(
       codigo_aluno NUMBER CONSTRAINT pk_alunos PRIMARY KEY,
       nome_aluno VARCHAR2(30) NOT NULL,
       nota1_aluno NUMBER NOT NULL,
       nota2_aluno NUMBER NOT NULL,
       media_aluno NUMBER
);



CREATE SEQUENCE AI_alunos
MINVALUE 1
START WITH 1
INCREMENT BY 1



CREATE OR REPLACE TRIGGER alunos_incrementar
BEFORE INSERT ON alunos
FOR EACH ROW
BEGIN
  :new.codigo_aluno := AI_alunos.NEXTVAL;
END;



CREATE OR REPLACE TRIGGER alunos_calcular_media
BEFORE INSERT ON alunos
FOR EACH ROW
BEGIN
  :new.media_aluno := (:new.nota1_aluno + :new.nota2_aluno)/2;
END;



INSERT INTO alunos (nome_aluno,nota1_aluno,nota2_aluno) VALUES ('William',3,7)

SELECT * FROM alunos;


DROP TABLE alunos;
DROP SEQUENCE AI_alunos;
DROP TRIGGER alunos_calcular_media;


-- --------------------------


CREATE TABLE produtos (
       codigo_produto NUMBER CONSTRAINT pk_produtos PRIMARY KEY,
       nome_produto VARCHAR2(30) NOT NULL,
       valor_produto NUMBER NOT NULL,
       valor_promocional NUMBER
);



CREATE SEQUENCE AI_produtos
MINVALUE 1
START WITH 1
INCREMENT BY 1;



CREATE OR REPLACE TRIGGER produtos_incrementar
BEFORE INSERT ON produtos
FOR EACH ROW
BEGIN
  :new.codigo_produto := AI_produtos.NEXTVAL;
END;



CREATE OR REPLACE TRIGGER produtos_calcular_valor_promocional
BEFORE INSERT ON produtos
FOR EACH ROW
BEGIN
  :new.valor_promocional := :new.valor_produto * 0.9;
END;



INSERT INTO produtos (nome_produto,valor_produto) VALUES ('Cachaça',10.50);


SELECT * FROM produtos;

DROP TABLE produtos;
DROP SEQUENCE AI_produtos;
DROP TRIGGER produtos_calcular_valor_promocional

