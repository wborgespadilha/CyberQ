CREATE TABLE pessoas(
       codigo_pessoa NUMBER CONSTRAINT pk_pessoa PRIMARY KEY,
       nome_pessoa VARCHAR2(30) NOT NULL,
       nascimento_pessoa DATE NOT NULL,
       signo_pessoa VARCHAR2(20)
);

CREATE SEQUENCE autoincrement
MINVALUE 1
START WITH 1
INCREMENT BY 1

CREATE OR REPLACE TRIGGER incrementar
BEFORE INSERT ON pessoas
FOR EACH ROW
BEGIN
  :new.codigo_pessoa := autoincrement.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER gerarsigno
BEFORE INSERT ON pessoas
FOR EACH ROW
DECLARE
  mes NUMBER;
  dia NUMBER;
  signo VARCHAR2(20);
BEGIN

  mes := TO_CHAR(:new.nascimento_pessoa,'MM');
  dia := TO_CHAR(:new.nascimento_pessoa,'DD');

  IF mes = 1 THEN
     IF dia < 20 THEN
        signo := 'Capricórnio';
      ELSE
        signo := 'Aquário';
      END IF;

  ELSIF mes = 2 THEN
    IF dia < 18 THEN
       signo := 'Aquário';
      ELSE
        signo := 'Peixes';
      END IF;

  ELSIF mes = 3 THEN
    IF dia < 20 THEN
       signo := 'Peixes';
      ELSE
        signo := 'Áries';
      END IF;

  ELSIF mes = 4 THEN
    IF dia < 20 THEN
       signo := 'Áries';
      ELSE
       signo := 'Touro';
      END IF;

  ELSIF mes = 5 THEN
    IF dia < 21 THEN
       signo := 'Touro';
      ELSE
       signo := 'Gêmeos';
      END IF;

  ELSIF mes = 6 THEN
    IF dia < 20 THEN
       signo := 'Gêmeos';
      ELSE
       signo := 'Câncer';
      END IF;

  ELSIF mes = 7 THEN
    IF dia < 22 THEN
       signo := 'Câncer';
      ELSE
       signo := 'Leão';
      END IF;

  ELSIF mes = 8 THEN
    IF dia < 22 THEN
       signo := 'Leão';
      ELSE
       signo := 'Virgem';
      END IF;

  ELSIF mes = 9 THEN
    IF dia < 22 THEN
       signo := 'Virgem';
      ELSE
       signo := 'Libra';
      END IF;

  ELSIF mes = 10 THEN
    IF dia < 22 THEN
       signo := 'Libra';
      ELSE
       signo := 'Escorpião';
      END IF;

  ELSIF mes = 11 THEN
    IF dia < 21 THEN
       signo := 'Escorpião';
      ELSE
       signo := 'Sagitário';
      END IF;

  ELSIF mes = 12 THEN
    IF dia < 21 THEN
       signo := 'Sagitário';
      ELSE
       signo := 'Capricórnio';
      END IF;
  END IF;

  :new.signo_pessoa := signo;

END;


INSERT INTO pessoas (nome_pessoa,nascimento_pessoa) VALUES ('William',to_date('27-01-2002','DD-MM-YYYY'));

SELECT * FROM pessoas

DROP TABLE pessoas;
DROP SEQUENCE autoincrement;
DROP TRIGGER incrementar;
DROP TRIGGER gerarsigno

------------------------------------


CREATE TABLE triangulos(
       codigo_triangulo NUMBER CONSTRAINT triangulo_pk PRIMARY KEY,
       lado_direito NUMBER NOT NULL,
       lado_esquerdo NUMBER NOT NULL,
       lado_inferior NUMBER NOT NULL,
       tipo_triangulo VARCHAR2(30)
);


CREATE SEQUENCE triangulo_autoincrement
MINVALUE 1
START WITH 1
INCREMENT BY 1

CREATE OR REPLACE TRIGGER triangulo_incrementar
BEFORE INSERT ON triangulos
FOR EACH ROW
BEGIN
  :new.codigo_triangulo := triangulo_autoincrement.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER triangulo_calcular_tipo
BEFORE INSERT ON triangulos
FOR EACH ROW
DECLARE 
    l1 NUMBER;
    l2 NUMBER;
    l3 NUMBER;
    tipo VARCHAR2(30);
BEGIN
  
    l1 := :new.lado_direito;
    l2 := :new.lado_esquerdo;
    l3 := :new.lado_inferior;

    IF l1 = l2 AND l2 = l3 THEN
      tipo := 'Equilátero';
     ELSIF l1 = l2 OR l2 = l3 THEN
       tipo := 'Isóceles';
     ELSE
       tipo := 'Escaleno';
     END IF;
     

  :new.tipo_triangulo := tipo;
END;


INSERT INTO triangulos (lado_direito,lado_esquerdo,lado_inferior) VALUES (5,5,5);

SELECT * FROM triangulos;

DROP TABLE triangulos;
DROP SEQUENCE triangulo_autoincremen;
DROP TRIGGER triangulo_incrementar;
DROP TRIGGER triangulo_calcular_tip;

















