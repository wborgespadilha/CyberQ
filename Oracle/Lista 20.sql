CREATE TABLE emprestimos (
       codigo NUMBER CONSTRAINT pk_emprestimo PRIMARY KEY,
       nome_pessoa VARCHAR2(50),
       nome_livro VARCHAR2(50),
       data_emprestimo DATE,
       data_devolucao DATE,
       total NUMBER    
)

CREATE SEQUENCE seq_emprestimos
MINVALUE 1
START WITH 1
INCREMENT BY 1

CREATE OR REPLACE TRIGGER ai_emprestimos
BEFORE INSERT ON emprestimos
FOR EACH ROW
BEGIN
  :new.codigo := seq_emprestimos.NEXTVAL;
END;

-------------------------------------------

CREATE OR REPLACE PROCEDURE cadastrar_emprestimo(
       nome VARCHAR2,
       livro VARCHAR2,
       dataemprestimo DATE
)
AS
BEGIN
  
  INSERT INTO emprestimos 
  (nome_pessoa,nome_livro,data_emprestimo) 
  VALUES (nome,livro,dataemprestimo);
  
  END;
  
-------------------------------------------

CREATE OR REPLACE FUNCTION calcular_dias(
       codigoinserido NUMBER,
       datadevolucao DATE
)
RETURN NUMBER
AS

diferenca_datas NUMBER;
dataemprestimo DATE;

BEGIN
  
  SELECT data_emprestimo 
  INTO dataemprestimo 
  FROM emprestimos 
  WHERE codigo = codigoinserido;

  SELECT (datadevolucao - dataemprestimo)
  INTO diferenca_datas 
  FROM DUAL;
  
  RETURN diferenca_datas;
                     
  END;
  
-------
  
CREATE OR REPLACE PROCEDURE alterar_emprestimo(
       codigoinserido NUMBER,
       datadevolucao DATE
)
AS

valor_pagamento NUMBER;

BEGIN
  
  valor_pagamento := calcular_dias(codigoinserido,datadevolucao);
  
  DBMS_OUTPUT.put_line('O total a pagar é de R$' || valor_pagamento);
  
  UPDATE emprestimos 
  SET data_devolucao = datadevolucao, 
  total = valor_pagamento
  WHERE codigo = codigoinserido;

END;


-------------------------------------------

BEGIN
cadastrar_emprestimo('William','As lindas tranças de um careca',TO_DATE('10/07/2022','DD-MM-YYYY'));
END;

SELECT * FROM emprestimos;

BEGIN
  alterar_emprestimo(1,TO_DATE('20/07/2022','DD-MM-YYYY'));
  END;
  
SELECT * FROM emprestimos;
  
