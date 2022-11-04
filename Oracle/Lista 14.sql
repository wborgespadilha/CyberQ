CREATE TABLE colaboradores(
       codigo_colaborador NUMBER CONSTRAINT colaborador_pk PRIMARY KEY,
       nome_colaborador VARCHAR2(30) NOT NULL,
       cargo_colaborador VARCHAR2(40) NOT NULL,
       salario_bruto NUMBER,
       imposto_renda NUMBER,
       vale_transporte NUMBER,
       vale_refeicao NUMBER,
       salario_liquido NUMBER
);

CREATE SEQUENCE ai_colaboradores
MINVALUE 1
START WITH 1
INCREMENT BY 1

CREATE OR REPLACE TRIGGER incrementar_colaboradores
BEFORE INSERT ON colaboradores
FOR EACH ROW
  BEGIN
  
  :new.codigo_colaborador := ai_colaboradores.NEXTVAL;
  
    END;

CREATE OR REPLACE TRIGGER cadastrar_salario
BEFORE INSERT ON colaboradores
FOR EACH ROW
  FOLLOWS incrementar_colaboladores
  DECLARE

  salario NUMBER;
  cargo VARCHAR2(40);

  BEGIN

    cargo := :new.cargo_colaborador;

    IF cargo = 'Desenvolvedor C#' THEN
      salario := 5000;
    ELSIF cargo = 'Desenvolvedor PHP' THEN
      salario := 4300;
    ELSIF cargo = 'Desenvolvedor Java' THEN
      salario := 5700;
    ELSIF cargo = 'Desenvolvedor Python' THEN
      salario := 4800;
    END IF;

    :new.salario_bruto := salario;

    END;
    
CREATE OR REPLACE TRIGGER cadastrar_ir
BEFORE INSERT ON colaboradores
FOR EACH ROW
  FOLLOWS cadastrar_salario
  DECLARE 
  
  salario NUMBER;
  desconto NUMBER;
  
  BEGIN
    
  salario := :new.salario_bruto;
  
  IF salario < 2000 THEN
    desconto := 0;
  ELSIF salario < 4500 THEN
    desconto := salario * 0.1;
  ELSIF salario < 5000 THEN
    desconto := salario * 0.15;
  ELSE
    desconto := salario * 0.2;
  END IF;     
  
  :new.imposto_renda := desconto;
  
    END;
    
CREATE OR REPLACE TRIGGER cadastrar_vt
BEFORE INSERT ON colaboradores
FOR EACH ROW
  FOLLOWS cadastrar_ir
  DECLARE
  
  vt NUMBER;
  salario NUMBER;
  
  BEGIN
  
    salario := :new.salario_bruto;
    
    vt := salario * 0.06;
    
    :new.vale_transporte := vt;
  
    END;
    
CREATE OR REPLACE TRIGGER cadastrar_va
BEFORE INSERT ON colaboradores
FOR EACH ROW
  FOLLOWS cadastrar_vt
  DECLARE
  
  va NUMBER;
  salario NUMBER;
  
  BEGIN
    
    salario := :new.salario_bruto;
    
    va := salario * 0.08;
    
    :new.vale_refeicao := va;
  
    END;
    
CREATE OR REPLACE TRIGGER cadastrar_salario_liquido
BEFORE INSERT ON colaboradores
FOR EACH ROW
  FOLLOWS cadastrar_va
  DECLARE
  
  salario NUMBER;
  ir NUMBER;
  vt NUMBER;
  va NUMBER;
  
  BEGIN
    
     salario := :new.salario_bruto;
     ir := :new.imposto_renda;
     vt := :new.vale_transporte;
     va := :new.vale_refeicao;
     
     :new.salario_liquido := salario - ir - vt - va;
     
     END;
     
INSERT INTO colaboradores (nome_colaborador,cargo_colaborador) VALUES ('William','Desenvolvedor C#');
   
SELECT * FROM colaboradores; 
  
DROP TABLE colaboradores;
DROP SEQUENCE ai_colaboradores;
DROP TRIGGER incrementar_colaboradores;
DROP TRIGGER cadastrar_salario;
DROP TRIGGER cadastrar_ir;
DROP TRIGGER cadastrar_vt;
DROP TRIGGER cadastrar_va;
DROP TRIGGER cadastrar_salario_liquido;
