CREATE TABLE alunos(
       nome VARCHAR2(40),
       turma VARCHAR2(10),
       nota1 NUMBER,
       nota2 NUMBER,
       nota3 NUMBER,
       turno VARCHAR2(10)    
);

INSERT INTO alunos VALUES('Ana Paula','7A',5,8,7,'Vespertino');
INSERT INTO alunos VALUES('Caio Neves','8B',3,4,2,'Matutino');
INSERT INTO alunos VALUES('Isabella Fontana','7C',9,8.5,9,'Vespertino');
INSERT INTO alunos VALUES('Daniel Luz','8A',2,5,3,'Vespertino');
INSERT INTO alunos VALUES('Gabriela Braga','8A',10,10,10,'Vespertino');
INSERT INTO alunos VALUES('Ellen Souza','7A',5,9,7,'Matutino');
INSERT INTO alunos VALUES('Luciana Biltz','8B',9.5,10,10,'Vespertino');
INSERT INTO alunos VALUES('Paulo Almeida','8A',10,10,10,'Matutino');
INSERT INTO alunos VALUES('Carla Malta','7B',3,7,9,'Matutino');
INSERT INTO alunos VALUES('Diogo Andrade','8C',10,9,10,'Vespertino');
INSERT INTO alunos VALUES('M?nica Mota','8A',7,7,8,'Vespertino');
INSERT INTO alunos VALUES('Juliana Lima','8C',9,8,2,'Vespertino');
INSERT INTO alunos VALUES('Marcelo Matos','7A',9,10,5,'Matutino');

-- Retornar nome, m?dia e situa??o (aprovado / reprovado)

SELECT nome,
((nota1+nota2+nota3)/3) AS media ,
(CASE WHEN ((nota1+nota2+nota3)/3) >= 7 THEN 'Aprovado' ELSE 'Reprovado' END )AS situacao
FROM alunos;

-- Quantidade de alunos por turno

SELECT turno, COUNT(*) FROM alunos GROUP BY turno;

-- Quantidade de alunos por turma

SELECT turma, COUNT(*) FROM alunos GROUP BY turma;

-- Nome e m?dia de todos os alunos com m?dia >= 7

SELECT nome,
((nota1+nota2+nota3)/3) AS media
FROM alunos
WHERE ((nota1+nota2+nota3)/3) >= 7;

-- Quantidade de alunos do vespertino reprovados

SELECT turma,COUNT(*) AS reprovados FROM alunos WHERE turno = 'Vespertino' GROUP BY turma;

-- Nome dos alunos com a maior m?dia

SELECT nome,((nota1+nota2+nota3)/3) AS media FROM alunos WHERE (nota1+nota2+nota3) = (SELECT MAX((nota1+nota2+nota3))FROM alunos);

-- M?dia de cada turma

SELECT turma,(SUM((nota1+nota2+nota3)/3)/COUNT(*)) AS media FROM alunos GROUP BY turma;

-- Migrar alunos da 8B para 8A

UPDATE alunos SET turma = '8A' WHERE turma = '8B';

-- Remover tabela

DROP TABLE alunos;
