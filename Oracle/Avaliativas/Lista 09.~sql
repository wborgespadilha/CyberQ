-- DDL

CREATE TABLE "PROFESSORES" (
  "CODIGO" INT,
  "NOME" VARCHAR2(40),
  constraint PROFESSORES_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "PROFESSORES_CODIGO_SEQ";

CREATE trigger "BI_PROFESSORES_CODIGO"
  before insert on "PROFESSORES"
  for each row
begin
  select "PROFESSORES_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "MATERIAS" (
  "CODIGO" INT NOT NULL,
  "CODIGOPROFESSOR" INT NOT NULL,
  "NOME" VARCHAR2(25) NOT NULL,
  constraint MATERIAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "MATERIAS_CODIGO_SEQ";

CREATE trigger "BI_MATERIAS_CODIGO"
  before insert on "MATERIAS"
  for each row
begin
  select "MATERIAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "TURMAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(2) NOT NULL,
  "TURNO" VARCHAR2(15) NOT NULL,
  constraint TURMAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "TURMAS_CODIGO_SEQ";

CREATE trigger "BI_TURMAS_CODIGO"
  before insert on "TURMAS"
  for each row
begin
  select "TURMAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "ALUNOS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(30) NOT NULL,
  constraint ALUNOS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "ALUNOS_CODIGO_SEQ";

CREATE trigger "BI_ALUNOS_CODIGO"
  before insert on "ALUNOS"
  for each row
begin
  select "ALUNOS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "NOTAS" (
  "CODIGO" INT NOT NULL,
  "NOME" VARCHAR2(255) NOT NULL,
  "NOTA" FLOAT NOT NULL,
  "CODIGOALUNO" INT NOT NULL,
  "CODIGOMATERIA" INT NOT NULL,
  "CODIGOTURMA" INT NOT NULL,
  constraint NOTAS_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "NOTAS_CODIGO_SEQ";

CREATE trigger "BI_NOTAS_CODIGO"
  before insert on "NOTAS"
  for each row
begin
  select "NOTAS_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "FINANCEIRO" (
  "CODIGO" INT NOT NULL,
  "VALOR" FLOAT NOT NULL,
  "PAGO" CHAR(1) CHECK ("PAGO" IN ('N','Y')) NOT NULL,
  "DATACOBRANCA" DATE NOT NULL,
  "CODIGOALUNO" INT NOT NULL,
  "CODIGOMATERIA" INT NOT NULL,
  "CODIGOTURMA" INT NOT NULL,
  constraint FINANCEIRO_PK PRIMARY KEY ("CODIGO"));

CREATE sequence "FINANCEIRO_CODIGO_SEQ";

CREATE trigger "BI_FINANCEIRO_CODIGO"
  before insert on "FINANCEIRO"
  for each row
begin
  select "FINANCEIRO_CODIGO_SEQ".nextval into :NEW."CODIGO" from dual;
end;

/
CREATE TABLE "ALUNOS_TURMAS" (
  "CODIGOALUNO" INT NOT NULL,
  "CODIGOTURMA" INT NOT NULL,
  "CODIGOMATERIA" INT NOT NULL);


/

ALTER TABLE "MATERIAS" ADD CONSTRAINT "MATERIAS_fk0" FOREIGN KEY ("CODIGOPROFESSOR") REFERENCES "PROFESSORES"("CODIGO");

ALTER TABLE "NOTAS" ADD CONSTRAINT "NOTAS_fk0" FOREIGN KEY ("CODIGOALUNO") REFERENCES "ALUNOS"("CODIGO");
ALTER TABLE "NOTAS" ADD CONSTRAINT "NOTAS_fk1" FOREIGN KEY ("CODIGOMATERIA") REFERENCES "MATERIAS"("CODIGO");
ALTER TABLE "NOTAS" ADD CONSTRAINT "NOTAS_fk2" FOREIGN KEY ("CODIGOTURMA") REFERENCES "TURMAS"("CODIGO");

ALTER TABLE "FINANCEIRO" ADD CONSTRAINT "FINANCEIRO_fk0" FOREIGN KEY ("CODIGOALUNO") REFERENCES "ALUNOS"("CODIGO");
ALTER TABLE "FINANCEIRO" ADD CONSTRAINT "FINANCEIRO_fk1" FOREIGN KEY ("CODIGOMATERIA") REFERENCES "MATERIAS"("CODIGO");
ALTER TABLE "FINANCEIRO" ADD CONSTRAINT "FINANCEIRO_fk2" FOREIGN KEY ("CODIGOTURMA") REFERENCES "TURMAS"("CODIGO");

ALTER TABLE "ALUNOS_TURMAS" ADD CONSTRAINT "ALUNOS_TURMAS_fk0" FOREIGN KEY ("CODIGOALUNO") REFERENCES "ALUNOS"("CODIGO");
ALTER TABLE "ALUNOS_TURMAS" ADD CONSTRAINT "ALUNOS_TURMAS_fk1" FOREIGN KEY ("CODIGOTURMA") REFERENCES "TURMAS"("CODIGO");
ALTER TABLE "ALUNOS_TURMAS" ADD CONSTRAINT "ALUNOS_TURMAS_fk2" FOREIGN KEY ("CODIGOMATERIA") REFERENCES "MATERIAS"("CODIGO");


-- DML:

-- Inserindo valores

INSERT INTO professores (nome) VALUES ('Renato');
INSERT INTO professores (nome) VALUES ('Oscar');
INSERT INTO professores (nome) VALUES ('Cátia');
INSERT INTO professores (nome) VALUES ('Osvaldo');
INSERT INTO professores (nome) VALUES ('Marília');
INSERT INTO professores (nome) VALUES ('Paula');
INSERT INTO professores (nome) VALUES ('Otávio');
INSERT INTO professores (nome) VALUES ('Airton');

INSERT INTO materias (codigoprofessor,nome) VALUES (1,'Matemática');
INSERT INTO materias (codigoprofessor,nome) VALUES (2,'Geografia');
INSERT INTO materias (codigoprofessor,nome) VALUES (7,'Química');
INSERT INTO materias (codigoprofessor,nome) VALUES (6,'Filosofia');
INSERT INTO materias (codigoprofessor,nome) VALUES (1,'Física');
INSERT INTO materias (codigoprofessor,nome) VALUES (3,'Português');
INSERT INTO materias (codigoprofessor,nome) VALUES (3,'Inglês');
INSERT INTO materias (codigoprofessor,nome) VALUES (6,'Sociologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (5,'Português');
INSERT INTO materias (codigoprofessor,nome) VALUES (4,'História');
INSERT INTO materias (codigoprofessor,nome) VALUES (4,'Sociologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (5,'Espanhol');
INSERT INTO materias (codigoprofessor,nome) VALUES (8,'Biologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (8,'Química');

INSERT INTO turmas (nome,turno) VALUES ('6A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('6B','Vespertino');
INSERT INTO turmas (nome,turno) VALUES ('7A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('7B','Vespertino');
INSERT INTO turmas (nome,turno) VALUES ('8A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('8B','Vespertino');

INSERT INTO alunos (nome) VALUES ('Alessandra');
INSERT INTO alunos (nome) VALUES ('Emanuela');
INSERT INTO alunos (nome) VALUES ('Cíntia');
INSERT INTO alunos (nome) VALUES ('Diego');
INSERT INTO alunos (nome) VALUES ('Eduardo');
INSERT INTO alunos (nome) VALUES ('Larissa');
INSERT INTO alunos (nome) VALUES ('Jonathan');
INSERT INTO alunos (nome) VALUES ('Cleber');
INSERT INTO alunos (nome) VALUES ('Jéssica');
INSERT INTO alunos (nome) VALUES ('Lucas');
INSERT INTO alunos (nome) VALUES ('Murilo');
INSERT INTO alunos (nome) VALUES ('Marcelo');
INSERT INTO alunos (nome) VALUES ('Rebeca');
INSERT INTO alunos (nome) VALUES ('Tatiana');
INSERT INTO alunos (nome) VALUES ('Taís');
INSERT INTO alunos (nome) VALUES ('Gabriel');
INSERT INTO alunos (nome) VALUES ('Felipe');
INSERT INTO alunos (nome) VALUES ('Eliza');
INSERT INTO alunos (nome) VALUES ('Sarah');
INSERT INTO alunos (nome) VALUES ('Patrícia');

INSERT INTO alunos_turmas VALUES (1,1,1);
INSERT INTO alunos_turmas VALUES (2,5,1);
INSERT INTO alunos_turmas VALUES (3,10,2);
INSERT INTO alunos_turmas VALUES (4,14,1);
INSERT INTO alunos_turmas VALUES (5,1,1);
INSERT INTO alunos_turmas VALUES (6,2,6);
INSERT INTO alunos_turmas VALUES (7,3,2);
INSERT INTO alunos_turmas VALUES (8,6,3);
INSERT INTO alunos_turmas VALUES (9,5,4);
INSERT INTO alunos_turmas VALUES (10,4,4);
INSERT INTO alunos_turmas VALUES (11,1,5);
INSERT INTO alunos_turmas VALUES (12,5,2);
INSERT INTO alunos_turmas VALUES (13,8,3);
INSERT INTO alunos_turmas VALUES (14,13,6);
INSERT INTO alunos_turmas VALUES (15,6,5);
INSERT INTO alunos_turmas VALUES (16,14,3);
INSERT INTO alunos_turmas VALUES (17,9,5);
INSERT INTO alunos_turmas VALUES (18,3,1);
INSERT INTO alunos_turmas VALUES (19,8,4);
INSERT INTO alunos_turmas VALUES (20,5,6);
INSERT INTO alunos_turmas VALUES (4,10,3);
INSERT INTO alunos_turmas VALUES (15,2,1);
INSERT INTO alunos_turmas VALUES (12,10,1);
INSERT INTO alunos_turmas VALUES (9,8,6);

INSERT INTO notas (nome,nota,codigoaluno,codigomateria,codigoturma) VALUES ('Prova 1',8.5,1,1,1);
INSERT INTO notas (nome,nota,codigoaluno,codigomateria,codigoturma) VALUES ('Prova 2',5,1,1,1);
INSERT INTO notas (nome,nota,codigoaluno,codigomateria,codigoturma) VALUES ('Prova 3',7,1,1,1);

INSERT INTO financeiro (valor,pago,datacobranca,codigoaluno,codigoturma,codigomateria) VALUES (500,'N',TO_DATE('01/22','MM-DD'),1,1,1);
INSERT INTO financeiro (valor,pago,datacobranca,codigoaluno,codigoturma,codigomateria) VALUES (500,'N',TO_DATE('01/22','MM-DD'),4,10,3);
INSERT INTO financeiro (valor,pago,datacobranca,codigoaluno,codigoturma,codigomateria) VALUES (500,'Y',TO_DATE('01/22','MM-DD'),4,14,1);

-------------------------------------------------------------

       -- Indice de filtros
       

    --Alunos:
    
-- Alunos por matéria e turma  
-- Quantidade de alunos em cada turma  
-- Quantidade de alunos por turno

   -- Filtros Professores
   
-- Nome de cada professor e matéria que leciona
-- Nome dos professores de matéria específica 
-- Matérias do professor específico  

   -- Filtros matérias
  
-- Alunos da matéria especifica
-- Quantidade de alunos matriculados por matéria

   -- Filtros gerais

-- Nome dos alunos, turma e matéria do professor especifico
-- Quantidade de alunos da turma específica que tem aula de matéria especifica com o professor especifico
-- Quantidade de alunos do turno especifico que tem aula de matéria especifica
   
   -- Filtro de notas

-- Lista de notas por matéria em cada turma, controle do professor
-- Notas do aluno
-- Boletim do aluno

   -- Filtro Financeiro
      
-- Alunos devedores
-- Faturas do aluno
-- Contas a pagar do aluno


-------------------------------------------------------------------

              -- Filtros alunos
       

-- Alunos por matéria e turma:


SELECT
alunos.nome,
materias.nome,
turmas.nome
FROM alunos_turmas

INNER JOIN alunos
ON alunos_turmas.codigoaluno = alunos.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigo

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo;


-- Quantidade de alunos em cada turma

SELECT
turmas.nome,
count(alunos_turmas.codigoturma) AS quantidade
FROM alunos_turmas
INNER JOIN turmas
ON turmas.codigo = alunos_turmas.codigoturma
GROUP BY turmas.nome;

-- Quantidade de alunos por turno

SELECT 
turno,
COUNT(alunos_turmas.codigoaluno)
FROM turmas
INNER JOIN alunos_turmas
ON alunos_turmas.codigomateria = turmas.codigo
GROUP BY turno;

      -- Filtros Professores
      

-- Nome de cada professor e matéria que leciona.

SELECT 
professores.nome,
materias.nome 
FROM professores
INNER JOIN materias
ON materias.codigoprofessor = professores.codigo;


-- Nome dos professores de química

SELECT 
professores.nome
FROM professores
INNER JOIN materias
ON materias.codigoprofessor = professores.codigo
WHERE materias.nome = 'Química';

-- Matérias do professor Airton

SELECT
materias.nome
FROM materias

INNER JOIN professores
ON materias.codigoprofessor = professores.codigo

WHERE professores.nome = 'Airton'


      -- Filtros matérias
      

-- Alunos da matéria de história

SELECT 
alunos.nome
FROM alunos_turmas

INNER JOIN alunos
ON alunos.codigo = alunos_turmas.codigoaluno

INNER JOIN materias
ON materias.codigo = alunos_turmas.codigomateria

WHERE materias.nome = 'História';

-- Quantidade de alunos matriculados por matéria

SELECT 
codigomateria,
COUNT(codigoaluno) AS alunosmatriculados
FROM alunos_turmas
GROUP BY codigomateria
ORDER BY codigomateria ASC;


      -- Filtros gerais
      

-- Nome dos alunos, turma e matéria do professor renato

SELECT 
alunos.nome,
turmas.nome,
materias.nome

FROM alunos_turmas

INNER JOIN alunos
ON alunos_turmas.codigoaluno = alunos.codigo

INNER JOIN turmas
ON alunos_turmas.codigomateria = turmas.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigo

INNER JOIN professores
ON materias.codigoprofessor = professores.codigo

WHERE professores.nome = 'Renato';


-- Quantidade de alunos da turma 6A que tem aula de matemática com o renato

SELECT
COUNT(codigoaluno)
FROM alunos_turmas

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigo

WHERE turmas.nome = '6A' AND materias.nome = 'Matemática'


-- Quantidade de alunos do vespertino que tem aula de biologia

SELECT 
COUNT(alunos_turmas.codigoaluno)
FROM alunos_turmas

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigo

WHERE turmas.turno = 'Vespertino' AND materias.nome = 'Biologia';


      -- Filtros Notas
      
      
-- Lista de notas por matéria em cada turma, controle do professor

SELECT 
notas.nome,
alunos.nome
notas.nota,
FROM notas

INNER JOIN alunos
ON alunos.codigo = notas.codigoaluno

INNER JOIN turmas
ON turmas.codigo = notas.codigoturma

INNER JOIN materias
ON materias.codigo = notas.codigomateria

WHERE turmas.nome = '6A' AND materias.nome = 'Matemática';

-- Notas do aluno

SELECT
materias.nome,
notas.nome,
notas.nota
FROM notas

INNER JOIN materias
ON materias.codigo = notas.codigomateria

INNER JOIN alunos
ON alunos.codigo = notas.codigoaluno

WHERE alunos.nome = 'Alessandra'

ORDER BY notas.codigomateria;

-- Boletim do aluno

SELECT
materias.nome,
AVG(notas.nota) AS media
FROM notas

INNER JOIN materias
ON materias.codigo = notas.codigomateria

INNER JOIN alunos
ON alunos.codigo = notas.codigoaluno

WHERE alunos.nome = 'Alessandra'

GROUP BY materias.nome;


      -- Filtro Financeiro
      
-- Alunos devedores

SELECT 
alunos.nome
FROM financeiro

INNER JOIN alunos
ON financeiro.codigoaluno = alunos.codigo

WHERE financeiro.pago = 'N'

GROUP BY alunos.nome;


-- Faturas do aluno

SELECT 
materias.nome AS materia,
financeiro.valor,
financeiro.pago
FROM financeiro

INNER JOIN alunos
ON financeiro.codigoaluno = alunos.codigo

INNER JOIN materias
ON materias.codigo = financeiro.codigomateria

WHERE alunos.nome = 'Diego';


-- Contas a pagar do aluno


SELECT 
materias.nome AS materia,
financeiro.valor,
financeiro.pago
FROM financeiro

INNER JOIN alunos
ON financeiro.codigoaluno = alunos.codigo

INNER JOIN materias
ON materias.codigo = financeiro.codigomateria

WHERE alunos.nome = 'Diego' AND financeiro.pago = 'N';





