CREATE TABLE clientes (
       codigo_cliente NUMBER CONSTRAINT pk_clientes PRIMARY KEY,
       nome_cliente VARCHAR2(30),
       email_cliente VARCHAR(50)
);
 -- SEQUENCE
CREATE SEQUENCE seq_codigo_clientes
MINVALUE 1
START WITH 1
INCREMENT BY 1

 -- TRIGGER AUTO INCREMENTE
CREATE OR REPLACE TRIGGER ai_clientes
BEFORE INSERT ON clientes
FOR EACH ROW
BEGIN
  :new.codigo_cliente := seq_codigo_clientes.NEXTVAL;  
  END;
     
 --  PROCEDURE CADASTRAR CLIENTE
CREATE OR REPLACE PROCEDURE cadastrarCliente(
       nome VARCHAR2,
       email VARCHAR
) 
AS
BEGIN
  INSERT INTO clientes (nome_cliente,email_cliente) VALUES (nome,email);
END;

 -- INSERIR NOVO CLIENTE
BEGIN
cadastrarCliente('Wdasdasd','adasdas@gmail.com');
END;
SELECT * FROM clientes;

 -- PROCEDURE CADASTRAR CLIENTE V2
CREATE OR REPLACE PROCEDURE cadastrarCliente(
       nome VARCHAR2,
       email VARCHAR
) 
AS
 tamanhonome NUMBER;
 tamanhoemail NUMBER;
 quantidade_registros NUMBER;
 quantidade_arrobas NUMBER;
BEGIN
  
  SELECT 
  COUNT(*) 
  INTO quantidade_registros
  FROM clientes 
  WHERE email_cliente = email;
  
  SELECT 
  LENGTH(email) - LENGTH(REPLACE(email,'@',NULL)) 
  INTO quantidade_arrobas 
  FROM dual;
  
  tamanhonome := LENGTH(nome);
  tamanhoemail := LENGTH(email);
  
  IF tamanhonome < 3 OR tamanhonome > 30 
    THEN
     DBMS_OUTPUT.put_line('Nome inválido (tamanho)!');
     
  ELSIF tamanhoemail < 10 OR tamanhoemail = null 
    THEN
      DBMS_OUTPUT.put_line('Email inválido (tamanho)!');
      
   ELSIF quantidade_arrobas != 1 
     THEN
       DBMS_OUTPUT.put_line('Email inválido (@)!');
            
    ELSIF quantidade_registros > 0 
      THEN
        DBMS_OUTPUT.put_line('Email já cadastrado!');
        
    ELSE
      INSERT INTO clientes (nome_cliente,email_cliente) VALUES (nome,email);
    END IF;
    
END;

 -- PROCEDURE ALTERAR CLIENTE
CREATE OR REPLACE PROCEDURE alterar_cliente(
       nomeantigo VARCHAR2,
       novonome VARCHAR2,
       novoemail VARCHAR
)
AS

quantidade_registros NUMBER;

BEGIN

  SELECT 
  COUNT(*)
  INTO quantidade_registros
  FROM clientes
  WHERE nome_cliente = nomeantigo;
  
  IF quantidade_registros = 0 
    THEN
      DBMS_OUTPUT.put_line('Cliente não encontrado!');
  ELSE
    
    UPDATE clientes 
    SET nome_cliente = novonome, 
    email_cliente = novoemail 
    WHERE
    nome_cliente = nomeantigo;
    
  END IF;
  

  END;

 -- PROCEDURE REMOVER CLIENTE PELO NOME

CREATE OR REPLACE PROCEDURE remover_cliente_pelo_nome(
       nome VARCHAR2
)
AS

quantidade_registros NUMBER;

BEGIN

  SELECT 
  COUNT(*)
  INTO quantidade_registros
  FROM clientes
  WHERE nome_cliente = nome;
  
  IF quantidade_registros = 0 
    THEN
      DBMS_OUTPUT.put_line('Cliente não encontrado!');
      
  ELSE
    DELETE clientes WHERE nome_cliente = nome;   
  END IF;
  
  END;
  

   -- PROCEDURE REMOVER CLIENTE PELO EMAIL

CREATE OR REPLACE PROCEDURE remover_cliente_pelo_email(
       email VARCHAR2
)
AS

quantidade_registros NUMBER;

BEGIN

  SELECT 
  COUNT(*)
  INTO quantidade_registros
  FROM clientes
  WHERE email_cliente = email;
  
  IF quantidade_registros = 0 
    THEN
      DBMS_OUTPUT.put_line('Cliente não encontrado!');
      
  ELSE
    DELETE clientes WHERE email_cliente = email;   
  END IF;
  
  END;
  
 -- TESTAR
 
  BEGIN
  cadastrarCliente('W','adasdas@gmail.com'); -- NOME CURTO
  cadastrarCliente('WDASDASDSADASDASDASDASDASDDASDASSDASDSADASDASDAD','adasdas@gmail.com'); -- NOME LONGO
  cadastrarCliente('WDASDASDASD','ad'); -- EMAIL CURTO
  cadastrarCliente('WDASDASDASD','adDASGMAIL.COM'); -- EMAIL SEM ARROBA
  cadastrarCliente('WDASDASDASD','ad@@DASGMAIL.COM'); -- EMAIL 2 ARROBAS
  cadastrarCliente('William','william@gmail.com');
  cadastrarCliente('William','william@gmail.com'); -- REGISTRO DUPLICADO
  END;
  
  SELECT * FROM clientes;
  
  -- DELETAR TUDO
