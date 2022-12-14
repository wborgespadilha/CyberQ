CREATE TABLE professores(
       codigo NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
       nome VARCHAR2(20),
       CONSTRAINT codigo_professores_pk PRIMARY KEY (codigo)
);

CREATE TABLE materias(
       codigomateria NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
       codigoprofessor NUMBER,
       nome VARCHAR2(20),
       CONSTRAINT codigo_materias_pk PRIMARY KEY (codigomateria),
       CONSTRAINT codigo_professor_fk FOREIGN KEY (codigoprofessor) REFERENCES professores(codigo)
);

CREATE TABLE turmas(
       codigo NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
       nome VARCHAR2(2),
       turno VARCHAR2(10),
       CONSTRAINT codigo_turmas_pk PRIMARY KEY (codigo)
);

CREATE TABLE alunos(
       codigo NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
       nome VARCHAR2(30),
       CONSTRAINT codigo_alunos_pk PRIMARY KEY (codigo)
);

CREATE TABLE alunos_turmas(
       codigoaluno NUMBER,
       codigomateria NUMBER,
       codigoturma NUMBER,
       CONSTRAINT codigoaluno_alunos_turmas_fk FOREIGN KEY (codigoaluno) REFERENCES alunos(codigo),
       CONSTRAINT codigomateria_alunos_turmas_fk FOREIGN KEY (codigomateria) REFERENCES materias(codigomateria),
       CONSTRAINT codigoturma_alunos_turmas_fk FOREIGN KEY (codigoturma) REFERENCES turmas(codigo)  
);

INSERT INTO professores (nome) VALUES ('Renato');
INSERT INTO professores (nome) VALUES ('Oscar');
INSERT INTO professores (nome) VALUES ('C?tia');
INSERT INTO professores (nome) VALUES ('Osvaldo');
INSERT INTO professores (nome) VALUES ('Mar?lia');
INSERT INTO professores (nome) VALUES ('Paula');
INSERT INTO professores (nome) VALUES ('Ot?vio');
INSERT INTO professores (nome) VALUES ('Airton');


INSERT INTO materias (codigoprofessor,nome) VALUES (1,'Matem?tica');
INSERT INTO materias (codigoprofessor,nome) VALUES (2,'Geografia');
INSERT INTO materias (codigoprofessor,nome) VALUES (7,'Qu?mica');
INSERT INTO materias (codigoprofessor,nome) VALUES (6,'Filosofia');
INSERT INTO materias (codigoprofessor,nome) VALUES (1,'F?sica');
INSERT INTO materias (codigoprofessor,nome) VALUES (3,'Portugu?s');
INSERT INTO materias (codigoprofessor,nome) VALUES (3,'Ingl?s');
INSERT INTO materias (codigoprofessor,nome) VALUES (6,'Sociologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (5,'Portugu?s');
INSERT INTO materias (codigoprofessor,nome) VALUES (4,'Hist?ria');
INSERT INTO materias (codigoprofessor,nome) VALUES (4,'Sociologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (5,'Espanhol');
INSERT INTO materias (codigoprofessor,nome) VALUES (8,'Biologia');
INSERT INTO materias (codigoprofessor,nome) VALUES (8,'Qu?mica');

INSERT INTO turmas (nome,turno) VALUES ('6A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('6B','Vespertino');
INSERT INTO turmas (nome,turno) VALUES ('7A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('7B','Vespertino');
INSERT INTO turmas (nome,turno) VALUES ('8A','Matutino');
INSERT INTO turmas (nome,turno) VALUES ('8B','Vespertino');


INSERT INTO alunos (nome) VALUES ('Alessandra');
INSERT INTO alunos (nome) VALUES ('Emanuela');
INSERT INTO alunos (nome) VALUES ('C?ntia');
INSERT INTO alunos (nome) VALUES ('Diego');
INSERT INTO alunos (nome) VALUES ('Eduardo');
INSERT INTO alunos (nome) VALUES ('Larissa');
INSERT INTO alunos (nome) VALUES ('Jonathan');
INSERT INTO alunos (nome) VALUES ('Cleber');
INSERT INTO alunos (nome) VALUES ('J?ssica');
INSERT INTO alunos (nome) VALUES ('Lucas');
INSERT INTO alunos (nome) VALUES ('Murilo');
INSERT INTO alunos (nome) VALUES ('Marcelo');
INSERT INTO alunos (nome) VALUES ('Rebeca');
INSERT INTO alunos (nome) VALUES ('Tatiana');
INSERT INTO alunos (nome) VALUES ('Ta?s');
INSERT INTO alunos (nome) VALUES ('Gabriel');
INSERT INTO alunos (nome) VALUES ('Felipe');
INSERT INTO alunos (nome) VALUES ('Eliza');
INSERT INTO alunos (nome) VALUES ('Sarah');
INSERT INTO alunos (nome) VALUES ('Patr?cia');


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

-- Nome do aluno, mat?ria e turma

SELECT
alunos.nome,
materias.nome,
turmas.nome
FROM alunos_turmas

INNER JOIN alunos
ON alunos_turmas.codigoaluno = alunos.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigomateria

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo

-- Nome de cada professor e mat?ria que leciona

SELECT 
professores.nome,
materias.nome 
FROM professores
INNER JOIN materias
ON materias.codigoprofessor = professores.codigo;

-- Quantidade de alunos em cada turma

SELECT
turmas.nome,
count(alunos_turmas.codigoturma) AS quantidade
FROM alunos_turmas
INNER JOIN turmas
ON turmas.codigo = alunos_turmas.codigoturma
GROUP BY turmas.nome

-- Quantidade de alunos por turno

SELECT 
turno,
COUNT(alunos_turmas.codigoaluno)
FROM turmas
INNER JOIN alunos_turmas
ON alunos_turmas.codigomateria = turmas.codigo
GROUP BY turno

-- Nome dos alunos, turma e mat?ria do professor renato

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
ON alunos_turmas.codigomateria = materias.codigomateria

INNER JOIN professores
ON materias.codigoprofessor = professores.codigo

WHERE professores.nome = 'Renato'

-- Nome dos professores de qu?mica

SELECT 
professores.nome
FROM professores
INNER JOIN materias
ON materias.codigoprofessor = professores.codigo
WHERE materias.nome = 'Qu?mica';

-- Alunos da mat?ria de hist?ria

SELECT 
alunos.nome
FROM alunos_turmas

INNER JOIN alunos
ON alunos.codigo = alunos_turmas.codigoaluno

INNER JOIN materias
ON materias.codigomateria = alunos_turmas.codigomateria

WHERE materias.nome = 'Hist?ria';

-- Quantidade de alunos matriculados por mat?ria

SELECT 
codigomateria,
COUNT(codigoaluno) AS alunosmatriculados
FROM alunos_turmas
GROUP BY codigomateria
ORDER BY codigomateria ASC;

-- Alunos que tem a professora c?tia na aula de ingl?s

SELECT
alunos.nome
FROM alunos_turmas

INNER JOIN alunos
ON alunos.codigo = alunos_turmas.codigoaluno

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigomateria

INNER JOIN professores
ON materias.codigoprofessor = professores.codigo

WHERE professores.nome = 'C?tia' AND materias.nome = 'Ingl?s';

-- Quantidade de alunos da turma 6A que tem aula de matem?tica com o renato

SELECT
COUNT(codigoaluno)
FROM alunos_turmas

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigomateria

WHERE turmas.nome = '6A' AND materias.nome = 'Matem?tica'

-- Mat?rias do professor Airton

SELECT
materias.nome
FROM materias

INNER JOIN professores
ON materias.codigoprofessor = professores.codigo

WHERE professores.nome = 'Airton'

-- Quantidade de alunos do vespertino que tem aula de biologia

SELECT 
COUNT(alunos_turmas.codigoaluno)
FROM alunos_turmas

INNER JOIN turmas
ON alunos_turmas.codigoturma = turmas.codigo

INNER JOIN materias
ON alunos_turmas.codigomateria = materias.codigomateria

WHERE turmas.turno = 'Vespertino' AND materias.nome = 'Biologia'

SELECT * FROM materias WHERE ;

-- Remover todas as tabelas

DROP TABLE alunos;
DROP TABLE turmas;
DROP TABLE materias;
DROP TABLE professores;
DROP TABLE alunos_turmas;

