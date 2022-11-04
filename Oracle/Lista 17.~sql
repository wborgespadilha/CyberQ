/*
.........................................
.........▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄...............
......▄▄█▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓█▄▄............
.....▄▀▀▓▒░░░░░░░░░░░░░░░░▒▓▓▀▄..........
....▄▀▓▒▒░░░░░░░░░░░░░░░░░░░▒▒▓▀▄........
....█▓█▒░░░░░░░░░░░░░░░░░░░░░▒▓▒▓█.......
...▌▓▀▒░░░░░░░░░░░░░░░░░░░░░░░░▒▀▓█......
..█▌▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▒▓█......
.▐█▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓█▌.....
.█▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓█.....
.█▐▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒█▓.....
█▓█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█▌▓█.....
█▓▓█▒░░░░▒█▄▒▒░░░░░░░░░▒▒▄█▒░░░░▒█▓▓█....
█▓█▒░▒▒▒▒░░▀▀█▄▄░░░░░▄▄█▀▀░░▒▒▒▒░▒█▓█....
█▓▌▒▒▓▓▓▓▄▄▄▒▒▒▀█░░░░█▀▒▒▒▄▄▄▓▓▓▓▒▒▐▓█...
██▌▒▓███▓█████▓▒▐▌░░▐▌▒▓████▓████▓▒▐██...
.██▒▒▓███▓▓▓████▓▄░░░▄▓████▓▓▓███▓▒▒██...
.█▓▒▒▓██████████▓▒░░░▒▓██████████▓▒▒▓█...
..█▓▒░▒▓███████▓▓▄▀░░▀▄▓▓███████▓▒▒▓█....
...█▓▒░▒▒▓▓▓▓▄▄▄▀▒░░░░░▒▀▄▄▄▓▓▓▓▒▒░▓█....
....█▓▒░▒▒▒▒░░░░░░▒▒▒▒░░░░░░▒▒▒▒░▒▓█.....
....█▓▓▒▒▒░░██░░▒▓██▓▒░░██░░▒▒▒▓▓█.......
....▀██▓▓▓▒░░▀░▒▓████▓▒░▀░░▒▓▓▓██▀.......
......░▀█▓▒▒░░░▓█▓▒▒▓█▓▒░░▒▒▓█▀░░█.......
......█░░██▓▓▒░░▒▒▒░▒▒▒░░▒▓▓██░░█........
......█▄░░▀█▓▒░░░░░░░░░░▒▓█▀░░▄█.........
.......█▓█░░█▓▒▒▒░░░░░▒▒▒▓█░░█▓█.........
.......▐█▓█░░█▀█▓▓▓▓▓▓█▀░░█░█▓█▌.........
.........█▓▓█░█░█░█▀▀▀█░█░▄▀░█▓█.........
........ █▓▓█░░▀█▀█░█░█▄█▀░░█▓▓█.........
..........█▓▓█░░░░▀▀▀▀░░░░░█▓▓█..........
............█▓▓▓░░░░░░░░░▓▓▓.............
................▓▓▓▓▓▓▓▓▓................
.........................................
*/


-- Criar tabela
CREATE TABLE pessoas (
       nome_pessoa VARCHAR2(20),
       quantidade_consoantes NUMBER,
       quantidade_vogais NUMBER
);

-- Criar procedure
CREATE OR REPLACE PROCEDURE cadastrar_pessoas(
       nome VARCHAR2
)
AS

indice NUMBER;
qtdconsoantes NUMBER;
qtdvogais NUMBER;
letra CHAR;

BEGIN

   indice := 1;
   qtdvogais := 0;
   qtdconsoantes := 0;
   
   LOOP

     SELECT UPPER(SUBSTR(nome,indice,1)) INTO letra FROM dual;

     IF letra = 'A' THEN
       qtdvogais := qtdvogais + 1;
       
     ELSIF letra = 'E' THEN
       qtdvogais := qtdvogais + 1;
       
     ELSIF letra = 'I' THEN
       qtdvogais := qtdvogais + 1;
       
     ELSIF letra = 'O' THEN 
       qtdvogais := qtdvogais + 1;
       
     ELSIF letra = 'U' THEN 
       qtdvogais := qtdvogais + 1;
       
     ELSE
       qtdconsoantes := qtdconsoantes + 1;
     END IF;
     
     indice := indice + 1;

     EXIT WHEN indice > LENGTH(nome);

   END LOOP;

  INSERT INTO pessoas (nome_pessoa,quantidade_consoantes,quantidade_vogais)
  VALUES (nome,qtdconsoantes,qtdvogais);

  END;


-- Inserir
BEGIN
  cadastrar_pessoas('AEIOUVWXYZ'); -- 5 vogais, 5 consoantes
END;

-- Visualizar
SELECT * FROM pessoas;

-- Excluir
DROP TABLE pessoas;











































