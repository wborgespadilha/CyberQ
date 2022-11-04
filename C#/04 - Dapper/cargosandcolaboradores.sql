CREATE TABLE cargos(
       codigo_cargo NUMBER PRIMARY KEY,
       nome_Cargo VARCHAR2(40)
);

CREATE SEQUENCE sequencia_cargos
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_cargos
BEFORE INSERT ON cargos
FOR EACH ROW 
BEGIN
    :new.codigo_cargo := sequencia_Cargos.NEXTVAL;
END;

INSERT ALL
       INTO cargos (nome_cargo) VALUES ('Desenvolvedor de sistemas')
       INTO cargos (nome_cargo) VALUES ('Analista de sistemas')
       INTO cargos (nome_cargo) VALUES ('Administrador de banco de dados')
       INTO cargos (nome_cargo) VALUES ('gerente de projetos')
SELECT * FROM dual;



SELECT * FROM cargos;

-----------------------------------

CREATE TABLE colaboradores(
       codigo_colaborador NUMBER PRIMARY KEY,
       nome_colaborador VARCHAR2(40),
       codigo_cargo NUMBER,
       FOREIGN KEY (codigo_cargo) REFERENCES cargos(codigo_cargo)
);

CREATE SEQUENCE sequencia_colaboradores
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER incrementar_colaboladores
BEFORE INSERT ON colaboradores
FOR EACH ROW
  BEGIN
    :new.codigo_colaborador := sequencia_colaboradores.NEXTVAL;
  END;
  
INSERT ALL
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('daniel',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('jonas',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('hellen',3)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('carlos',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('yuri',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('carla',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('luana',1)
       INTO colaboradores (nome_colaborador,codigo_cargo) VALUES ('diogo',4)
SELECT * FROM dual;



SELECT * FROM colaboradores;




















